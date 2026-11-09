using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Armors
{
    [AutoloadEquip(EquipType.Legs)]
    internal class SpongePants : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Green;

            Item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.endurance += 0.02f;
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
