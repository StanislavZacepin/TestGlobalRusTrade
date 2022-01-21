using System;

namespace TestGlobalRusTrade.Entity.Models
{
    public class Precipitation
    {
        private string _Precipitation;
        private string[] _precipitation = { "солнечно", "облачно", "небольшой дождь", "сильный дождь", "гроза" };
        public Precipitation(int i)
        {
            _Precipitation = _precipitation[i];
        }

        public override string ToString()
        {
            return _Precipitation;
        }
    }
}
