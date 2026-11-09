using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Projectiles.Weapons;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Weapons.Ammo
{
    internal class WoodPellet : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 8;

            Item.damage = 4;
            Item.DamageType = DamageClass.Ranged;
            Item.knockBack = 1f;
            Item.rare = ItemRarityID.White;

            Item.maxStack = 9999;
            Item.consumable = true;

            Item.ammo = AmmoID.Dart;
            Item.shoot = ModContent.ProjectileType<WoodPelletProjectile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe(100)
                .AddIngredient(ItemID.Wood)
                .Register();
        }
    }
}
