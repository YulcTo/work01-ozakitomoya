using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai
{
    public abstract class Character
    {
        public float HP
        { get; private set; }
        public float MaxHP
        { get; private set; }
        public float AttackPoint
        { get; private set; }
        public float DefencePoint
        { get; private set; }


        public Character(float maxHP, float attackPoint, float defencePoint)
        {
            this.MaxHP = maxHP;
            this.HP = maxHP;
            this.AttackPoint = attackPoint;
            this.DefencePoint = defencePoint;
        }

      


        public void Attack(Character target)
        {
            //ダメージ計算
            float damage = Functions.CalcDamage(this, target);

            //相手のHPを減らす
            target.HP -= damage;
        }
    }
}
