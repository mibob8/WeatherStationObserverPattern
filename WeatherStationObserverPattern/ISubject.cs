using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationObserverPattern
{
    interface ISubject
    {
        List<IObserver> observers { get; set; }

        void AddObserver(IObserver observer); 
        void RemoveObserver(IObserver observer);
        void Notify(); 
    }
}
