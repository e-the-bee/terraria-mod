using TutorialMod.Content.Projectiles.Weapons;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Weapons
{
    internal class SpongeSpear:ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
            ItemID.Sets.Spears[Item.type] = true;
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() 
        {
            Item.rare = 2;
            Item.value = Item.sellPrice(silver: 10);

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 48;
            Item.useTime = 56;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;

            Item.damage = 25;
            Item.crit = 6;
            Item.knockBack = 6.5f;
            Item.noUseGraphic = true;
            Item.DamageType = DamageClass.Melee;
            Item.noMelee = true;

            Item.shootSpeed = 1.5f;
            Item.shoot = ModContent.ProjectileType<SpongeSpearProjectile>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }

        public override bool? UseItem(Player player)
        {
            if (!Main.dedServ && Item.UseSound.HasValue)
            {
                SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
            }
            return null;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpongeBar>(14)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
