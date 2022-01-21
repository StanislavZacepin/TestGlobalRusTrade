using System;


namespace TestGlobalRusTradeTest.Entity.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime _Date { get; set; }
        public int _MinimumTemperature { get; set; }
        public int _MaximumTemperature { get; set; }
        public int _Pressure { get; set; }
        public int _Humidity { get; set; }
        public Wind _Wind { get; set; }

        public Precipitation _Precipitation { get; set; }





    }
}
