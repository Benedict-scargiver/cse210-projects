using System;

namespace Activities
{
    public class RunningActivity : Activity
    {
        private double _distance; // in kilometers

        public RunningActivity(DateTime date, int minutes, double distance)
            : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance() => _distance;
        public override double GetSpeed() => (_distance / Minutes) * 60;
        public override double GetPace() => Minutes / _distance;
    }
}
