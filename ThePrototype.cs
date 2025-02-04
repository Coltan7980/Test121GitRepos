//Written by Coltan Paul
//2/4/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class ThePrototype
    {   //Class Variables
        private int pilotNumber = -1;
        private int hunterNumber = -1;
        //Gets and Sets
        public int PilotNumber
        {
            get { return pilotNumber; }
            set { pilotNumber = value; }
        }
        public int HunterNumber
        {
            get { return hunterNumber; }
            set { hunterNumber = value; }
        }
    }
}
