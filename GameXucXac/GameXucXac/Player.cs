using System;
namespace GameXucXac
{
    public class Player
    {
        private int currentPoint;
        private string name;

        public string Name
        {
            get => name;
        }

        public int Point
        {
            get => currentPoint;
            set
            {
                currentPoint = value;
            }
        }

        public Player(string _name)
        {
            name = _name;
        }

        public Player(string _name, string name) : this(_name)
        {
            this.name = name;
        }

        public virtual int Roll(Dice dice)
        {
            return 0;
        }
    }
}
