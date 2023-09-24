namespace Swordman
{
    internal enum PlayerType
    {
        Strength,
        Intelligence,
        Agile
    }

    internal struct BaseState
    {
        public PlayerType type;
        public int HP;
        public int MP;
        public int AttackPoint;
        public int AttackSpeed;
        public int MoveSpeed;
    }

    internal struct State
    {
        public BaseState origin;

        public int defensePoint;
        public int strength;
        public int intelligence;
        public int agile;

        public float moveSpeedRate;
        public float attackSpeedRate;
        public float skillCoolingRate;
        public float defenseRate;

        public int manaRecoveryPoint;
        public int lifeRecoveryPoint;
        public float manaRecoveryRate;
        public float lifeRecoveryRate;

        /*
         * 命中率，吸血
         */
        public float hitRate;
        public float lifeStealRate;

        /*
         * 攻击加成，技能加成
         */
        public float attackBonus;
        public float skillBonus;

        /*
         * 魔法抗性，物理抗性
         *
         * 被攻击结算时首先参与计算，所受伤害*(1-抗性)，然后在与护甲值作计算
         */
        public float magicResistance;
        public float damageResistance;

        /*
         * 技能暴击几率，攻击暴击几率
         *
         *
         */
        public float skillCritRate;
        public float attackCritRate;
        public float damageReflectionRate;
        public float ignoringMagicResistance;
        public float ignoringDefense;
        public float manaSaveRate;
    }

    public abstract class Player
    {
        public int HP { get; set; }
        public int MP { get; set; }
        public string Name { get; set; } = "unknown";
    }
}