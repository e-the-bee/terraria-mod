using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using System;
using System.Security.AccessControl;
using TutorialMod.Content.Projectiles.Weapons;

namespace TutorialMod.Content.Projectiles.Weapons
{
    internal class SpongeDartProjectile:ModProjectile
    {

        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            Projectile.width = 18;
            Projectile.height = 18;

            Projectile.aiStyle = 1;

            Projectile.friendly = true;
            Projectile.hostile = false;

            Projectile.penetrate = 3;

            Projectile.timeLeft = 600;
            
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;

            Projectile.extraUpdates = 0;

            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;

            AIType = ProjectileID.WoodenArrowFriendly;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Vector2 launchVelocity = new Vector2(-oldVelocity.X / 2, -oldVelocity.Y / 2);
            Projectile.penetrate--;
            if(Projectile.penetrate <= 0)
            {
                Projectile.Kill();
                return false;
            }

            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);

            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int randAngle = rnd.Next(-5, 5);
                Projectile.NewProjectile(Projectile.InheritSource(Projectile), Projectile.Center, launchVelocity, ModContent.ProjectileType<BubbleProjectile>(), Projectile.damage / 3, Projectile.knockBack, Projectile.owner);
                launchVelocity = launchVelocity.RotatedBy(MathHelper.ToRadians(randAngle));
            }

            SoundEngine.PlaySound(SoundID.NPCHit25, Projectile.position);

            if(Math.Abs(Projectile.velocity.X - oldVelocity.X) > float.Epsilon)
            {
                Projectile.velocity.X = -oldVelocity.X;
            }

            if(Math.Abs(Projectile.velocity.Y - oldVelocity.Y) > float.Epsilon)
            {
                Projectile.velocity.Y = -oldVelocity.Y;
            }

            return false;
        }

        public override void OnKill(int timeLeft)
        {
            Vector2 launchVelocity = new Vector2(-Projectile.velocity.X / 2, -Projectile.velocity.Y / 2);
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                int randAngle = rnd.Next(-5, 5);
                Projectile.NewProjectile(Projectile.InheritSource(Projectile), Projectile.Center, launchVelocity, ModContent.ProjectileType<BubbleProjectile>(), Projectile.damage / 3, Projectile.knockBack, Projectile.owner);
                launchVelocity = launchVelocity.RotatedBy(MathHelper.ToRadians(randAngle));
            }
        }
    }
}
