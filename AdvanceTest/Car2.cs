using System;
using System.Runtime.Remoting.Channels;

namespace AdvanceTest
{
    class Car2 : ICar
    {
        public int Wheel { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public event EventHandler<SpeedEventArgs> SetCar;



        public void SetSpeed(int speed)
        {
            Speed = speed;
            Console.WriteLine($"Speed set {Color +  " " + Speed}");
           
                OnSetCar(speed);
           
        }

        protected virtual void OnSetCar(int speed)
        {
            SetCar?.Invoke(this, new SpeedEventArgs() { Speed = speed });
        }
    }
}