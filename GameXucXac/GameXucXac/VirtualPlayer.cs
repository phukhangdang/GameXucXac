﻿using System;
namespace GameXucXac
{
    public class VirtualPlayer : Player
    {
        // private Dice dice = new Dice();

        public VirtualPlayer(string name) : base(name)
        {
        }

        public void Reaction()
        {
            Console.WriteLine("I'm Win!!!");
        }

        public override int Roll(InterfaceDice _dice)
        {
            return _dice.rollDice();
        }


    }
}
