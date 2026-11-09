using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Content.Projectiles.Weapons
{
    internal class SpongeSpearProjectile : ModProjectile
    {
        protected virtual float HoldoutRangeMin => 0f;
        protected virtual float HoldoutRangeMax => 48f;

        public override void SetDefaults()
        {
            Projectile.width = 72;
            Projectile.height = 72;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.tileCollide = false;
            Projectile.ownerHitCheck = true;
        }

        public override bool PreAI()
        {

            Player player = Main.player[Projectile.owner];
            int duration = player.itemAnimationMax;

            Projectile.velocity = Vector2.Normalize(Projectile.velocity);

            player.heldProj = Projectile.whoAmI;

            if (Projectile.timeLeft > duration) 
                Projectile.timeLeft = duration;
            


            Projectile.velocity = Vector2.Normalize(Projectile.velocity);

            float halfDuration = duration * 0.5f;
            float progress;

            if (Projectile.timeLeft < halfDuration)
            {
                progress = Projectile.timeLeft / halfDuration;
            }
            else
            {
                progress = (duration - Projectile.timeLeft) / halfDuration;
            }

            Projectile.Center = player.MountedCenter + Vector2.SmoothStep(Projectile.velocity * HoldoutRangeMin, Projectile.velocity * HoldoutRangeMax, progress);

            if (player.direction == 1)
            {
                Projectile.rotation = player.itemRotation + MathHelper.ToRadians(135f);
            }
            else
            {
                Projectile.rotation = player.itemRotation + MathHelper.ToRadians(315f);
            }

            return false;
        }

        public override void ModifyDamageHitbox(ref Rectangle hitbox)
        {

            Player player = Main.player[Projectile.owner];
            hitbox.Width = 72;
            hitbox.Height = 72;
            hitbox.Offset(0, 0);
            
        }
    }
}
