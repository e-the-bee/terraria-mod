using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

namespace TutorialMod.Content.Dusts
{
    internal class BubbleParticle:ModDust
    {

        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = false;
            dust.noLight = true;
            dust.alpha = 20;
        }

        public override bool Update(Dust dust)
        {
            dust.velocity.Y += 1f;
            dust.position.Y += dust.velocity.Y;
            dust.position.X += dust.velocity.X;
            dust.scale *= 0.99f;
            if(dust.scale < 0.3f)
            {
                dust.active = false;
            }

            return false;
        }
    }
}
