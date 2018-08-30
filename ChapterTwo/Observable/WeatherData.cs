using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Runtime.Serialization;

namespace ChapterTwo
{
    public class WeatherData : ISubject
    {
        private ArrayList Observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            Observers = new ArrayList();
        }

        #region ISubject Members

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int i = Observers.IndexOf(observer);
            if (i >= 0)
            {
                Observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in Observers)
            {
                o.Update(_temperature, _humidity, _pressure);
            }
        }

        #endregion

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementChanged();
        }
    }

    // Provider
    public class Weather
    {
        float temp,humidity,pressure;

        public Weather(float temp, float hum, float press)
        {
            this.temp = temp;
            this.humidity = hum;
            this.pressure = press;
        }

        public float Temperature 
        { 
            get{return temp;} 
            set{ temp = value;} 
        }

        public float Humidity 
        { 
            get{return humidity;}
            set{humidity = value;} 
        }

        public float Pressure 
        { 
            get{return pressure;}
            set{pressure = value;}
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    public class WeatherDataObservable : IObservable<Weather>
    {
        private List<IObserver<Weather>> observers;

        public WeatherDataObservable()
        {
            observers = new List<IObserver<Weather>>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Weather>> _observers;
            private IObserver<Weather> _observer;

            public Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void TrackWeather(Weather weatherData)
        {
            foreach (var observer in observers)
            {
                if (null == weatherData)
                    observer.OnError(new WeatherException());
                else
                    observer.OnNext(weatherData);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }

    [Serializable]
    public class WeatherException : Exception
    {
        public WeatherException() { }
    }
}
