using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTwo
{
    public class CurrentConditionsDisplay : IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            if(weatherData != null)
                weatherData.RegisterObserver(this);
        }

        public void RemoveObservation()
        {
            weatherData.RemoveObserver(this);
        }

        public void Update(float temp, float hum, float press)
        {
            this.temperature = temp;
            this.humidity = hum;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions: " + temperature + "F Degrees and " + humidity + "% Humidity");
        }
    }

    public class CurrentConditionsDisplayObserver : IObserver<Weather>
    {
        private IDisposable unsubscriber;
        private string _name;

        public CurrentConditionsDisplayObserver(string name)
        {
            this._name = name;
        }

        public string Name { get { return this._name;} }

        public virtual void Subscribe(IObservable<Weather> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine("The Weather update has completed transmitting data to {0}.", this.Name);
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: Weather can't be determined.",this.Name);
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine("{3} : Temperature : {0}, Humidity : {1}, Pressure : {2}",
                value.Temperature,value.Humidity,value.Pressure,this.Name);
        }
    }
}
