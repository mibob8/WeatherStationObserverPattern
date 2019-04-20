using System.Collections.Generic;

namespace WeatherStationObserverPattern
{
    internal class Termometer : ISubject
    {
        public List<IObserver> observers { get; set; } = new List<IObserver>();
        private float temperature { get; set; }
          
        internal void SetTemperature(float temperature)
        {
            this.temperature = temperature;
            Notify();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
                observer.Display();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}