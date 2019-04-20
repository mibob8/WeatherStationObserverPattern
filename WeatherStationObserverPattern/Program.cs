using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var termometer = new Termometer(); 
            var display = new Display(termometer); 
            termometer.SetTemperature(32); 
            Console.ReadKey(); 
        }
    }
}
