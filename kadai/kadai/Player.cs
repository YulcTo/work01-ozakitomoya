using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai
{
    public class Player : Character
    {
        public string Name
        { get; private set; }
        public int Level
        { get; private set; }


        public Player(string name, float maxHP, float attackPoint, float defencePoint)
            : base(maxHP, attackPoint, defencePoint)
        {
            this.Name = name;
            this.Level = 1;
        }

   
    }
}

