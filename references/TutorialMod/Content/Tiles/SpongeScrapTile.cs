using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TutorialMod.Content.Tiles
{
    internal class SpongeScrapTile : ModTile
    {

        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 1500;
            Main.tileShine2[Type] = false;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 350;

            AddMapEntry(new Color(0, 200, 0), CreateMapEntryName());

            DustType = DustID.BubbleBurst_Blue;
            HitSound = SoundID.NPCHit25;

            MineResist = 0.5f;
            MinPick = 55;

        }
    }
}
