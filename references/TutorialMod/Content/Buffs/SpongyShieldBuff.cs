using Terraria;
using Terraria.ModLoader;
using TutorialMod.Content.Projectiles.Minions;

namespace TutorialMod.Content.Buffs
{
    internal class SpongyShieldBuff:ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 2*player.ownedProjectileCounts[ModContent.ProjectileType<SpongyShieldMinion>()];

            if (player.ownedProjectileCounts[ModContent.ProjectileType<SpongyShieldMinion>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
                return;
            }

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}
