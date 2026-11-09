using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;
using Terraria.ID;
using TutorialMod.Content.Items.Weapons.Ammo;

namespace TutorialMod.Content.Items.Weapons
{
    internal class WoodenPipe:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 8;

            Item.useTime = 30;
            Item.useAnimation = 30;

            Item.useStyle = ItemUseStyleID.Shoot;

            Item.autoReuse = true;

            Item.UseSound = SoundID.Item63;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 7;
            Item.knockBack = 0f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.Seed;
            Item.useAmmo = AmmoID.Dart;
            Item.shootSpeed = 7.5f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0f, -5f);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 6)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
