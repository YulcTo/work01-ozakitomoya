using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai
{
    public class Enemy : Character
    {
        public string Name
        { get; private set; }
        public int GainExp
        { get; private set; }
        public int Level
        { get; private set; }



        public Enemy(string name, float maxHP, float attackPoint, float defencePoint, int gainExp)
            : base(maxHP, attackPoint, defencePoint)
        {
            this.Name = name;
            this.GainExp = gainExp;
        }

      
    }
}
