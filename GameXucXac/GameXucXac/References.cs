using System;
using System.Collections;
using System.Collections.Generic;

namespace GameXucXac
{
    public class References
    {
        public const int MAX_PLAYER = 4;
        //private ArrayList listHumanPlayer = new ArrayList();
        //private ArrayList listVirtualPlayer = new ArrayList();
        private List<Player> listPlayer = new List<Player>();
        private List<Dice> listDice = new List<Dice>();
        private int turn = 1;
        private Player winner;
        private bool isGameOver = false;

        public void Start()
        {
            listDice.Add(new Dice());
            SetOrder();
            Console.WriteLine("==========================");
            while (!isGameOver)
            {
                Console.WriteLine("Turn {0}", turn);
                NextPlayer();
                ++turn;
                Console.WriteLine("==========================");
            }
            GameOver();
        }

        private void SetOrder()
        {
            int numPlayer;
            string namePlayer;
            int numBot = 1;
            Console.Write("Nhap so nguoi choi: ");
            numPlayer = int.Parse(Console.ReadLine());
            for (int i = 0; i < MAX_PLAYER; ++i)
            {
                if (i < numPlayer)
                {
                    Console.Write("Ten nguoi choi {0}: ", i + 1);
                    namePlayer = Console.ReadLine();
                    listPlayer.Add(new HumanPlayer(namePlayer));
                }
                else
                {
                    listPlayer.Add(new VirtualPlayer("Bot" + numBot++));
                }
            }
        }

        private void NextPlayer()
        {
            foreach (Player player in listPlayer)
            {
                int point = player.Roll(listDice[0]);
                player.Point += point;
                if (player.Point > 21)
                {
                    player.Point = 0;
                }
                if (player.Point == 21)
                {
                    isGameOver = true;
                    winner = player;
                }
                Console.WriteLine("Diem cua {0} la: {1}", player.Name, player.Point);
            }
        }

        private void GameOver()
        {
            Console.WriteLine("==========================");
            if (winner is VirtualPlayer)
            {
                Console.Write(winner.Name + ": ");
                ((VirtualPlayer)winner).Reaction();
            }
            if (winner is HumanPlayer)
            {
                Console.WriteLine("Chuc mung {0}", winner.Name);
            }
            Console.WriteLine("Game Over!!!");
        }

        public References()
        {
        }

    }
}
