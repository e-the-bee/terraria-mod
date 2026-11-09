using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Projectiles.Minions;
using TutorialMod.Content.Buffs;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Weapons
{
    internal class SpongyShield:ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
            ItemID.Sets.GamepadWholeScreenUseRange[Type] = true;
            ItemID.Sets.LockOnIgnoresCollision[Type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item44;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Summon;
            Item.damage = 6;
            Item.knockBack = 2f;
            Item.mana = 10;
            Item.noMelee = true;

            Item.value = Item.buyPrice(gold: 1);

            Item.shoot = ModContent.ProjectileType<SpongyShieldMinion>();
            Item.buffType = ModContent.BuffType<SpongyShieldBuff>();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            position = Main.MouseWorld;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.AddBuff(Item.buffType, 2);

            var projectile = Projectile.NewProjectileDirect(source, position, velocity, type, damage, Main.myPlayer);
            projectile.originalDamage = Item.damage;

            return false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpongeBar>(15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
