using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationObserverPattern
{
    class Display : IObserver
    {
        Termometer termometer { get; set; }
        float temperature { get; set; }

        public Display(Termometer termometer)
        {
            this.termometer = termometer;
            termometer.AddObserver(this);
        }
         
        public void Update(float temperature)
        {
            this.temperature = temperature; ;
        }

        void IObserver.Display()
        {
            Console.WriteLine($"Current temperature is {temperature} degree.");
        }
    }
}
