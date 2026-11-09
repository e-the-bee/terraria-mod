using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Armors
{
    [AutoloadEquip(EquipType.Body)]
    internal class SpongeShirt:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Green;

            Item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            // Give Buff Immunity
            player.buffImmune[BuffID.OnFire] = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpongeBar>(23)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
