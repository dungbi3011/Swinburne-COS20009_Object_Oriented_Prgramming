using System;

namespace Counter
{
    public class Counter
    {
        private int _count;
        private string _name;

        public int Ticks
        {
            get
            {
                return _count; //return value of _count
            }
        }

        public string Name
        {
            get
            {
                return _name; //return value of name
            }
            set
            {
                _name = value; //assigns a value to _name
            }
        }

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count++;
        }

        public void Reset()
        {
            _count = 0;
        }

    }
}
