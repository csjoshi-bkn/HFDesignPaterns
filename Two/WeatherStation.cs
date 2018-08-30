using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterTwo
{
    class WeatherStation
    {
        static void Main(/*string[] args*/)
        {
            #region Using the Custom Interface

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(85, 70, 31.4f);
            
            currentDisplay.RemoveObservation();
            
            weatherData.SetMeasurements(75, 90, 35.4f);

            #endregion

            #region Using IObservable of .Net Framework

            //Using .Net Frameowrk In-Built IObservable & IObserver Interfaces.
            Console.WriteLine();
            Console.WriteLine(".Net Style Observer Pattern");
            Console.WriteLine();

            // ONE PROVIDER
            WeatherDataObservable provider = new WeatherDataObservable(); 
            
            // MANY SUBSCRIBER
            CurrentConditionsDisplayObserver subscriberOne = new CurrentConditionsDisplayObserver("First");
            subscriberOne.Subscribe(provider);

            CurrentConditionsDisplayObserver subscriberTwo = new CurrentConditionsDisplayObserver("Second");
            subscriberTwo.Subscribe(provider);

            CurrentConditionsDisplayObserver subscriberThree = new CurrentConditionsDisplayObserver("Third");
            subscriberThree.Subscribe(provider);

            provider.TrackWeather(new Weather(80, 65, 30.4f));
            //subscriberOne.Unsubscribe();
            provider.TrackWeather(new Weather(85, 70, 31.5f));
            //subscriberTwo.Unsubscribe();
            provider.TrackWeather(new Weather(75, 90, 33.3f));
            //subscriberThree.Unsubscribe();
            //provider.TrackWeather(null);
            provider.EndTransmission();

            #endregion
        }
    }
}
