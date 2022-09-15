using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai
{
    public class Functions
    {

        public static float CalcDamage(Character attacker, Character target)
        {
            //ダメージ計算
            float damage = attacker.AttackPoint - target.DefencePoint;
            if (damage < 1) damage = 1;
            return damage;
        }

        //0:バトル継続中 1:プレイヤーが勝った 2: 敵が勝った
        public static int Battle(Player player, Enemy enemy)
        {
            Console.WriteLine("戦闘開始！");
            int battleState = 0;
            while (battleState == 0)
            {
                //Enter押すまで処理を止める
                Console.ReadLine();

                //改善点:Attackメソッドの中でダメージ表示をコンソールに出す
                player.Attack(enemy);
                enemy.Attack(player);
                Console.WriteLine("Lv " + player.Level + " name :" + player.Name + ":" + " HP :" + player.HP + ":" + "攻撃力　;" + player.AttackPoint +"防御力"+player.DefencePoint +
                    "Lv " + enemy.Level + ": name :" + enemy.Name + "HP :" + enemy.HP + "攻撃力　:" + enemy.AttackPoint+"防御力"+enemy.DefencePoint);

                //勝敗判定
                if (player.HP <= 0)
                    battleState = 2;
                else if (enemy.HP <= 0)
                    battleState = 1;
                else
                    battleState = 0;
            }
            return battleState;
        }


        




    }
}
