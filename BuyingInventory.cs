//Written by Coltan Paul
//2/4/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class BuyingInventory
    { //class Variables
        private int number = -1;

        //Gets and Sets
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        //Methods
        public string DisplayItems()
        {
            string message = "";
            message = message + "The following items are available:" + "\n";
            message = message + "1 - Rope" + "\n";
            message = message + "2 - Torches" + "\n";
            message = message + "3 - Climbing Equipment" + "\n";
            message = message + "4 - Clean Water" + "\n";
            message = message + "5 - Machete" + "\n";
            message = message + "6 - Canoe" + "\n";
            message = message + "7 - Food Supplies" + "\n";
            message = message + "What number do you want to see the price of?";
            return message;
        }
        
            
    }
}
