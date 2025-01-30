using System.Runtime.InteropServices;

namespace Practice_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TemperatureCalculator temperatureCalculator = new TemperatureCalculator();
            
            temperatureCalculator.Farenheight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(temperatureCalculator.ToString());
        }
    }
}
