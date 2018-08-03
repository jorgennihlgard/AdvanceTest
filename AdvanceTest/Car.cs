using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTest
{
    public class Car : ICar
    {
        public int Wheel { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

      

        public void SetSpeed(int speed)
        {
            Speed = speed;
            Console.WriteLine($"Speed set Car1 {Speed}");
        }








        public int Adding(int a, int b)
        {
            return a + b;
        }

    }
}
