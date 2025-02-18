using System;

namespace Activities
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public DateTime Date => _date;
        public int Minutes => _minutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{_date.ToShortDateString()} - {GetType().Name} ({_minutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min/km";
        }
    }
}
