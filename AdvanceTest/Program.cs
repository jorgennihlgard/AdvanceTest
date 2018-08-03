using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTest
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void MyName(string name)
        {
            Console.WriteLine($"My name is {name} ");
        }
    }

    internal interface IComputer
    {
        void Name();
        void CountAge(int r);
    }

    class Computer1 : IComputer
    {
        public void CountAge(int r)
        {
            Console.WriteLine("Cop 1 is yalking" + r);
        }

        public void Name()
        {
            Console.WriteLine("com1");
        }
    }
    class Computer2 : IComputer
    {
        public void CountAge(int r)
        {
            Console.WriteLine("Cop 2 is yalking" + r);
        }

        public void Name()
        {
            Console.WriteLine("com2");
        }
    }
    class Person : Animal
    {
        public string Address { get; set; }

        public override void MyName(string name)
        {
            Console.WriteLine("Can you say my name from the Person class" + name);
        }
        
    }

    class Indian : Animal
    {
        public string Address { get; set; }

        public override void MyName(string name)
        {
            Console.WriteLine("From the Indian class" + name);
        }
    }


    class Rr
    {
        private IComputer _com;

        public void De(IComputer computer)
        {
            _com = computer;
        }

       

        public void vw(IComputer computer)
        {
            computer.Name();
        }
    }
   

    class Program
    {

        public List<Animal> Fff()
        {
            return new List<Animal>()
            {
                new Animal() {Age = 23, Name = "jo"},
                new Animal() {Age = 43, Name = "per"}

            };
        }
        


        static void Main(string[] args)
        {
            //Car2 car = new Car2(){Color = "Yellow", Speed = 100, Wheel = 4};
            Car2 car2 = new Car2(){ Color = "Blue", Speed = 150, Wheel = 8 };
            Center center = new Center(car2);
            center.PrintCar(car2);
            Message message = new Message();
            
            car2.SetCar += message.OnStopCar;

           
           
            center.PrintCar(car2);
            car2.SetSpeed( 120);
            center.PrintCar(car2);
            center.StopCar(car2);

            center.PrintCar(car2);
            IList<Animal> lok = new List<Animal>();
            lok.Add(new Animal(){Age = 42,Name = "pol"});
            lok.Add(new Animal() { Age = 424, Name = "def" });

       
         
           
            Rr nunu = new Rr();
            nunu.vw(new Computer2());

        
            
            var program = new Program().Fff();
          
            var s = program.FindAll(p => p.Age > 33);

            foreach (var animal in s)
            {
                Console.WriteLine(animal.Age);
            }
            

            //Person p = new Person()
            //{
            //    Address = "Kust"
            //};

            //Indian a = new Indian()
            //{
            //    Name = "Jorgen",
            //    Age = 45
            //};

            //List<Animal> members = new List<Animal>();
            //members.Add(a);
            //members.Add(p);
            //foreach (var item in members)
            //{
            //    if (item is Indian)
            //    {
            //        Animal aa = item as Indian;

            //        aa.MyName("JOr");
            //        Console.WriteLine(aa.Name);

            //    }
            //    if (item is Person)
            //    {
            //        Person pp = item as Person;

            //        pp.MyName("Lotta");
            //    }
            //}

            //foreach (var it in members)
            //{
            //    it.MyName("hepp");
            //}

            //Animal animal = new Person();
            //Person p = new Person();
            //var f = animal is Person;


            Console.ReadLine();
        }

        
    }
}
