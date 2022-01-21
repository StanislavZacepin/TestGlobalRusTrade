namespace TestGlobalRusTrade.Entity.Models
{
    public class Wind
    {
        public Wind(int i, int b)
        {
            _wind = i;
            _Direction = _direction[b];
        }
        private int _wind { get; set; }

        private string _Direction { get; set; }

        private string[] _direction = { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ" };

        public override string ToString() => $"{_wind}=>{_Direction}";
    }
}
