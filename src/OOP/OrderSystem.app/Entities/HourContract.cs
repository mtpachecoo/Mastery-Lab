using System.Numerics;

namespace OrderSystem.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double _valuePerHour { get; set; }
        public int Hours { get; set; }
        
        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            _valuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * _valuePerHour;
        }
    }
}