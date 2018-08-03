using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTest
{
    class Center
    {
        private ICar _theCar;

        
       
       

        public Center(ICar car)
        {
            _theCar = car;
        }

        public void PrintCar(ICar car)
        {
            Console.WriteLine("Speed: " +car.Speed + " Wheel: " + car.Wheel + " Color: " + car.Color);
        }

        public void StopCar(ICar car)
        {
            _theCar.Speed = car.Speed = 0;
        }
    }
}
