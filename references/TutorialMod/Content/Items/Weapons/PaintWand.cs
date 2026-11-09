using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using TutorialMod.Content.Projectiles.Weapons;
using Microsoft.Xna.Framework;
using TutorialMod.Content.Items.Placeables;
using Terraria.GameContent.Creative;

namespace TutorialMod.Content.Items.Weapons
{
    internal class PaintWand:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.DamageType = DamageClass.Magic;
            Item.noMelee = true;
            Item.mana = 2;
            Item.damage = 10;
            Item.knockBack = 0.5f;

            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.autoReuse = true;

            Item.shoot = ModContent.ProjectileType<PaintProjectile>();
            Item.shootSpeed = 15f;
        }
    }
}
