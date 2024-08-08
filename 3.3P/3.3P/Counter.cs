using System;

namespace Unit_Test
{
    public class Counter
    {
        private string _name;
        int _count;

        public Counter(string name)
        {
            _name = name;
            _count = 0;
        }

        public void Increment()
        {
            _count += 1;
        }

        public void Reset()
        {
            _count = 0;
        }

        public int Ticks
        {
            get { return _count; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

    }
    
}

