using System;
namespace GameXucXac
{
    public class HumanPlayer : Player
    {
        // private Dice dice = new Dice();
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int Roll(Dice dice)
        {
            Console.ReadKey();
            return dice.rollDice();
        }
    }
}
