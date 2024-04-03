using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Time
    {
        public int Amount { get; set; }
        public string Type { get; set; }
        public Time ()
        {
            Amount = 0;
            Type = "Not set";
        }
        public Time(int Amount)
        {
            this.Amount = Amount;
            Type = "Not set";
        }
        public override string? ToString()
        {
            return $"Amount of unknown time = {Amount}, Type = {Type}";
        }
        public virtual int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Time equal)
                return Amount == equal.Amount && Type == equal.Type;
            return false;
        }
    }
    public class Minute : Time
    {
        public int MinutesInHour { get; set; }

        public Minute()
        {
            Amount = 0;
            Type = "Minute";
            MinutesInHour = 60;
        }
        public Minute(int Amount) :
            base(Amount)
        {
            Type = "Minute";
            MinutesInHour = 60;
        }

        public override string? ToString()
        {
            return $"Minutes = {Amount}, Type = {Type}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Minute equal)
                return Amount == equal.Amount && Type == equal.Type && MinutesInHour == equal.MinutesInHour;
            return false;
        }
    }
    public class Hour : Time
    {
        public int HoursInDay { get; set; }
        public Hour() 
        {
            Amount = 0;
            Type = "Hour";
            HoursInDay = 24;
        }
        public Hour(int Amount) :
            base(Amount)
        {
            Type = "Minute";
            HoursInDay = 24;
        }
        public override string? ToString()
        {
            return $"Minutes = {Amount}, Type = {Type}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Hour equal)
                return Amount == equal.Amount && Type == equal.Type && HoursInDay == equal.HoursInDay;
            return false;
        }
    }
    public class Doba
    {
        public Minute MinuteCl = new Minute();
        public Hour HourCl = new Hour();
        public string DayPeriod { get; set; }
        public Doba()
        {
            MinuteCl.Amount = 0;
            HourCl.Amount = 0;
            DayPeriod = WhichDayPartIsIt();
        }
        public Doba(int Hours, int Minutes)
        {
            MinuteCl.Amount = Minutes;
            HourCl.Amount = Hours;
            DayPeriod = WhichDayPartIsIt();
        }
        public override string? ToString()
        {
            return $"Time = {HourCl.Amount}:{MinuteCl.Amount}, Hours in a day = {HourCl.HoursInDay}, Minutes in an hour = {MinuteCl.MinutesInHour}";
        }
        public virtual int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Doba equal)
                return HourCl.Amount == equal.HourCl.Amount && MinuteCl.Amount == equal.MinuteCl.Amount && DayPeriod == equal.DayPeriod;
            return false;
        }
        public string WriteTime()
        {
            return $"Time = {HourCl.Amount}:{MinuteCl.Amount}";
        }
        public string WhichDayPartIsIt()
        {
            double DayPartPerc = (HourCl.Amount + (MinuteCl.Amount) / (1.0 * MinuteCl.MinutesInHour)) / (1.0 * HourCl.HoursInDay);
            if (DayPartPerc >= 0 && DayPartPerc < 0.25)
                return "Night";
            if (DayPartPerc >= 0.25 && DayPartPerc < 0.5)
                return "Morning";
            if (DayPartPerc >= 0.5 && DayPartPerc < 0.75)
                return "Day";
            return "Evening";
        }
    }
}
