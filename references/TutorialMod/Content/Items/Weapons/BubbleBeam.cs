using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using TutorialMod.Content.Projectiles.Weapons;
using Microsoft.Xna.Framework;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Weapons
{
    internal class BubbleBeam:ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 2;
            Item.damage = 10;
            Item.knockBack = 0.5f;
            Item.rare = ItemRarityID.Green;

            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.autoReuse = true;

            Item.UseSound = SoundID.Item21;

            Item.shoot = ModContent.ProjectileType<BubbleProjectile>();
            Item.shootSpeed = 10f;
        }

        public override void SetStaticDefaults()
        {
            Item.staff[Type] = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            Vector2 muzzleOffset = Vector2.Normalize(velocity) * 50f;

            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }

            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpongeBar>(12)
                .AddIngredient(ItemID.FallenStar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
