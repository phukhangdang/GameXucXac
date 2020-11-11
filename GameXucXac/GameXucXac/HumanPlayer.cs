using System;
namespace GameXucXac
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int Roll(InterfaceDice _dice)
        {
            Console.ReadKey();
            return _dice.rollDice();
        }
    }
}
