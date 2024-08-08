using System;
using System.Collections.Generic;
using System.Text;
using Unit_Test;

namespace CounterClock
{
    public class Clock
    {
        private Counter _second;
        private Counter _minute;
        private Counter _hour;
        public Clock()
        {

            _second = new Counter("seconds");
            _minute = new Counter("minutes");
            _hour = new Counter("hours");

        }

        public void Tick()
        {
            _second.Increment();
            if (_second.Ticks == 60)
            {
                _minute.Increment();
                _second.Reset();
                if (_minute.Ticks == 60)
                {
                    _hour.Increment();
                    _minute.Reset();    
                }
            }
        }

        public string ReadTime
        {
            get
            {
                return $"{_hour.Ticks:00}:{_minute.Ticks.ToString("00")}:{_second.Ticks.ToString("00")}";
            }
        }

        public void ResetClock()
        {
            _second.Reset();
            _minute.Reset();
            _hour.Reset();
        }
    }
}
