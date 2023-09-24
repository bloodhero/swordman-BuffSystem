namespace Swordman
{
    internal static class CalculationFormula
    {
        // 物理减损伤害 = 护甲值*0.06 /（1+护甲值*0.06）

        public static float DamageAfterDenfense(ushort denfense)
        {
            return 1 - denfense * 0.06f / (1 + denfense * 0.06f);
        }

        /*
         * 单局中英雄法术抗性可由三种管道获得：
         * ① 英雄护甲获得25%法术抗性；
         * ② 英雄技能获得的法术抗性，如邓艾R技能、董卓R技能、文丑E技能；
         * ③ 由装备获得的法术抗性，单局中装备带来的法术抗性效果不可迭加，
         * 取最大值，如抗魔  *赋魔披肩提升30%法术抗性等
         *
         * 最终法术抗性=1-（1-护甲法抗）*（1-技能法抗）*（1-装备法抗）*100%；
         *
         * 例如：R技能满级的邓艾佩戴抗魔*赋魔披肩后；
         * 最终法术抗性=1-(1-25%)*(1-28%)*(1-30%)=62%
         */

        public static float MagicResistance(float defense, float skill, float equioment)
        {
            return 1 - (1 - defense) * (1 - skill) * (1 - equioment);
        }

        /*
         * [忽视抗性]
         * 无视敌人一定百分比的法术抗性
         * 计算方式：  目标抗性*（1-忽视抗性）= 最终抗性
         * 例如：目标法术抗性为40%，技能忽视目标20%的法术抗性
         * 效果：目标最终抗性=40%*(1-20%)=32%
         */

        public static float MagicResistanceAfterNeglect(float target, float neglect)
        {
            return 1 - target * (1 - neglect);
        }

        /*
         * [法术穿透]
         * 降低敌人一定百分比的法术抗性
         * 计算方式：  目标抗性 － 法术穿透 = 最终抗性
         * 例如：目标法术抗性为25%，物品附加法术穿透为20%
         * 效果：目标最终抗性=25%－20%=5%
         */

        public static float MagicResistanceAfterPenetrate(float target, float penetrate)
        {
            return 1 - (target - penetrate);
        }

        public static ushort DamageWithFloat(ushort low, ushort high)
        {
            ushort damage = 0;

            return damage;
        }
    }
}