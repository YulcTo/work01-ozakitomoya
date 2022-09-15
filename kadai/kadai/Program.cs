using kadai;
Player player = new Player("田中", 50f, 10f, 5f);


int battleState = 0;
s
while (battleState != 2)
{
    Enemy enemy = new Enemy("スライム",10f, 3f, 2f, 5);

    Console.WriteLine("Lv " + player.Level + " name :" + player.Name + ":" + " HP :" + player.HP + ":" + "攻撃力　;" + player.AttackPoint + "防御力" + player.DefencePoint +
                   "Lv " + enemy.Level + ": name :" + enemy.Name + "HP :" + enemy.HP + "攻撃力　:" + enemy.AttackPoint + "防御力" + enemy.DefencePoint);


    battleState = 0;

    battleState = Functions.Battle(player, enemy);

    if (battleState == 1)
    {

        Console.WriteLine("プレイヤーの勝ち");

    }
    else
    {
        Console.WriteLine("プレイヤーの負け");
    }


}
Console.WriteLine("バトル終了");