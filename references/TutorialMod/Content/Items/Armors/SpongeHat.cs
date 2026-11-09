using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using TutorialMod.Content.Items.Placeables;

namespace TutorialMod.Content.Items.Armors
{
    [AutoloadEquip(EquipType.Head)]
    internal class SpongeHat:ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

            // ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false; //Don't draw head
            // ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true; // Enable Hair
            //ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true; // Masks
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
            player.statLifeMax2 += 20;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            bool bodyMatch = body.type == ModContent.ItemType<SpongeShirt>();
            bool legsMatch = legs.type == ModContent.ItemType<SpongePants>();
            return bodyMatch && legsMatch;
            // return body.type == ModContent.ItemType<SpongeShirt>() && legs.type = ModContent.ItemType<SpongePants>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = Language.GetTextValue("4 Defense" + "\nIncreased Life Regeneration" + "\n+3% Damage Reduction");

            player.statDefense += 4;
            player.lifeRegen += 2;
            player.endurance += 0.03f;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<SpongeBar>(17)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
