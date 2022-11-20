using System;
using System.Threading;

namespace Game;

class Game
{
    private int PlayerHP { get; set; }
    private int EnemyHP { get; set; }

    public Game(int playerHP, int enemyHP)
    {
        this.PlayerHP = playerHP;
        this.EnemyHP = enemyHP;

        int playerDamage;
        int enemyDamage;

        int turn = 1;

        while (playerHP > 0 && enemyHP > 0)
        {

            Random rand = new Random();

            playerDamage = rand.Next(2,9);
            enemyDamage = rand.Next(2,9);

            playerHP -= enemyDamage;
            enemyHP -= playerDamage;

            Console.WriteLine("\n----------------------------------------------------------------------");
            
            Console.WriteLine($"Turno {turn}");
            Console.WriteLine($"O Inimigo recebeu {playerDamage} de dano | Vida do Inimigo: {enemyHP} / 100");
            Console.WriteLine($"O Jogador recebeu {enemyDamage} de dano | Vida do Jogador: {playerHP} / 100");
            
            Console.WriteLine("----------------------------------------------------------------------");

            turn += 1;

            Thread.Sleep(2000);
        }

        if (enemyHP <= 0 && playerHP > 0)
        {
            Console.WriteLine("\nO Inimigo foi derrotado, você venceu :)\n");
        }
        else if (playerHP <= 0 && enemyHP > 0)
        {
            Console.WriteLine("\nO Jogador foi derrotado, você perdeu :(\n");
        }
        else
        {
            Console.WriteLine("\nA Batalha foi tão intensa que os dois morreram, épico :O\n");
        }
    }
}