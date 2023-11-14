using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses
{
    public class Point2D
    {
        private int x;
        private int y; 

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }   
    }
    public class Character
    {
        private static int speed = 10;
        public int Health { get; set; } = 100;
        public string Race { get; private set; }
        public Character(string race)
        {
            Race = race;
        }

        public int PrintSpeed()
        {
            return speed;
        }
        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
