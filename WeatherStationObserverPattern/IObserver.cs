using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationObserverPattern
{
    interface IObserver
    {
        void Update(float temperature);
        void Display();
    }
}
