using System;

namespace Activities
{
    public class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance() => (_laps * 50) / 1000.0; // Converts meters to km
        public override double GetSpeed() => (GetDistance() / Minutes) * 60;
        public override double GetPace() => Minutes / GetDistance();
    }
}
