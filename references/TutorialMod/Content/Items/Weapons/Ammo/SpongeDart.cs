using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Projectiles.Weapons;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Weapons.Ammo
{
    internal class SpongeDart:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 28;

            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 1.25f;
            Item.rare = ItemRarityID.Green;

            Item.maxStack = 9999;
            Item.consumable = true;

            Item.ammo = AmmoID.Dart;
            Item.shoot = ModContent.ProjectileType<SpongeDartProjectile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe(100)
                .AddIngredient<SpongeBar>(1)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
