using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Practice_File
{
    internal class TemperatureCalculator
    {
        private double farenheight = -999.9;

        public double Farenheight
        {
            get { return this.farenheight; }
            set { this.farenheight = value; }
        }

        public double CalcCelsius()
        {
            return (Farenheight - 32.0) * (5.0/9.0);
        }

        public double CalcKelvin()
        {
            return CalcCelsius() + 273.15;
        }
        public double CalcRankine()
        {
            return Farenheight + 45967.0;
        }
        public override string ToString()
        {
            string msg = "";
            msg = msg + "In Celcius :" + CalcCelsius() + "\n";
            msg = msg + "In Kelvin :" + CalcKelvin() + "\n";
            msg = msg + "In Rankine :" + CalcRankine() + "\n";

            return msg;
        }
    }
}