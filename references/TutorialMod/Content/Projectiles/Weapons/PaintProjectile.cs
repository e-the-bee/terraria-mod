using Microsoft.Xna.Framework;
using SteelSeries.GameSense;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Content.Dusts;

namespace TutorialMod.Content.Projectiles.Weapons
{
    internal class PaintProjectile:ModProjectile
    {
        public override void SetDefaults()
        {
            int rnd = new Random().Next(1, 3);
            Projectile.scale = rnd;
            Projectile.rotation = rnd * rnd;

            Projectile.width = 10;
            Projectile.height = 10;

            Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = true;

            Projectile.DamageType = DamageClass.Magic;

            Projectile.aiStyle = -1;

            Projectile.penetrate = 1;
        }

        public override void AI()
        {
            Projectile.velocity.Y += 0.1f;
            Projectile.position.Y += Projectile.velocity.Y;
        }

        public override void OnKill(int timeLeft)
        {
            for (int k = 0; k < 10; ++k)
            {
                
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Paint, Projectile.velocity.X * -0.1f, Projectile.velocity.Y * -0.1f, 0, default(Color), 1f);
            }

        }
    }
}
