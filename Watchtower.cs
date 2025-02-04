//Written by Coltan Paul
//2/4/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Watchtower
    {
        private int x = -9999;
        private int y = -9999;

        //Gets and Sets
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        //Methods
        public string CalcDirection()
        {
            string Direction = "n/a";
            if (Y > 0)
            {
                if (X < 0)
                { Direction = "NorthWest"; }

                else if (X == 0)
                { Direction = "North"; }

                else if (X > 0)
                { Direction = "NorthEast"; }
            }

            else if (Y == 0)
            {
                if (X < 0)
                { Direction = "West"; }

                else if (X == 0)
                { Direction = "!"; }

                else if (X > 0)
                { Direction = "East"; }
            }

            else if (Y < 0)
            {
                if (X < 0)
                { Direction = "SouthWest"; }

                else if (X == 0)
                { Direction = "South"; }

                else if (X > 0)
                { Direction = "East"; }

            }
            return Direction;
        }
        
    }
}
