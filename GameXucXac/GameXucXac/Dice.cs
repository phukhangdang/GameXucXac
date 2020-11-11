using System;
namespace GameXucXac
{
    public class Dice : InterfaceDice
    {
        private int[] dice = { 1, 2, 3, 4, 5, 6};

        public int rollDice()
        {
            Random r = new Random();
            return dice[r.Next(1, 6)];
        }
    }
}
