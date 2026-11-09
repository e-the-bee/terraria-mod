using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Content.Dusts;

namespace TutorialMod.Content.Projectiles.Weapons
{
    internal class BubbleProjectile:ModProjectile
    {

        public override void SetDefaults() 
        {
            Projectile.width = 16;
            Projectile.height = 16;

            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = true;

            Projectile.DamageType = DamageClass.Magic;

            Projectile.aiStyle = -1;

            Projectile.penetrate = 1;
        }

        public override void AI()
        {
            Projectile.ai[0]++;
            if (Projectile.ai[0] < 60f)
            {
                Projectile.velocity *= 0.99f;

            } else
            {
                Projectile.velocity *= 0.95f;
                if (Projectile.ai[0] >= 120)
                {
                    Projectile.Kill();
                }
            }
        }

        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item54, Projectile.position);

            for (int k = 0; k < 3; ++k)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<BubbleParticle>(), Projectile.velocity.X * 2f, Projectile.velocity.Y * 2f, 0, default(Color), 1f);
            }
        }
    }
}
