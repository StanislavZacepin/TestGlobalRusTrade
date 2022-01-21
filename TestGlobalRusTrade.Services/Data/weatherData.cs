using System;
using System.Collections.Generic;
using System.Linq;
using TestGlobalRusTradeTest.Entity.Models;

namespace TestGlobalRusTrade.Services.Data
{
    public static class weatherData
    {
        static Random random = new Random();
        public static List<Weather> _Weathers
        {
            get => Enumerable.Range(0, 10).Select(i => new Weather
            {
                _Date = i < 1 ? DateTime.Today.Date : DateTime.Today.AddDays(i).Date,
                _MinimumTemperature = i < 4 ? random.Next(-10, -5) : random.Next(-2, 3),
                _MaximumTemperature = i < 4 ? random.Next(-20, -12) : random.Next(0, 8),
                _Pressure = random.Next(700, 800),
                _Humidity = random.Next(79, 90),
                _Wind = new Wind(random.Next(4, 6), random.Next(0, 7)),
                _Precipitation = new Precipitation(random.Next(0, 5)),

            }).ToList();

        }


    }
}
