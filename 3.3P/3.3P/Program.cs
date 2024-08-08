using System;
using Unit_Test;

namespace CounterClock
{
    
    public class MainClass
    {

        private static void Main()
        {
            Clock time = new Clock();
            for (int i = 0; i < 18; i++)
            {
                time.Tick();
                Console.WriteLine(time.ReadTime);
            }

            time.ResetClock();
            for (int i = 0; i < 3600; i++)
            {
                time.Tick();
                Console.WriteLine(time.ReadTime);   
            }

        }
    }
}

