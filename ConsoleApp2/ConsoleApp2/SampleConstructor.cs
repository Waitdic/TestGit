using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SampleConstructor
    {
        public int carSpeed;
        public string carName;

        public void Car()
        {
            Console.WriteLine("We are now working with car. What are car have specification?");
            SampleConstructor a = new SampleConstructor();
            a.Specification();
            Console.WriteLine("speed {0}, name {1}", a.carSpeed, a.carName);

            SampleConstructor b = new SampleConstructor();
            b.Specification(10);
            //Console.WriteLine("speed {0}, name {1}", b.carSpeed, b.carName);
            

            SampleConstructor c = new SampleConstructor();
            c.Specification("GEB");
            Console.WriteLine("speed {0}, name {1}", c.carSpeed, c.carName);

            SampleConstructor d = new SampleConstructor();
            d.Specification(10, "GEB");
            Console.WriteLine("speed {0}, name {1}", d.carSpeed, d.carName);

            Console.ReadKey();
        }

        public void Specification()
        {
            carSpeed = 10;
            carName = "JD";
        }

        public void Specification(int carSpeed)
        {
            this.carSpeed = carSpeed;
        }

        public void Specification(string carName)
        {
            this.carName = carName;
        }

        public void Specification(int carSpeed, string carName)
        {
            this.carSpeed = carSpeed;
            this.carName = carName;
        }

    }
}
