using System;
namespace GameXucXac
{
    public class Player
    {
        public int currentPoint { get; set; }
        public string name { get; set; }

        public Player(string _name)
        {
            name = _name;
        }

        public virtual int Roll(InterfaceDice _dice)
        {
            return 0;
        }
    }
}
