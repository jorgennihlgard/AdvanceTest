using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTest
{
    public class Message
    {
        public void OnStopCar(object sender, SpeedEventArgs e)
        {
            Car2 car = (Car2) sender;
            Console.WriteLine($"Följande har stannat: {car.Speed  + " " + car.Color} and speed args {e.Speed}");
        }

       
    }
}
