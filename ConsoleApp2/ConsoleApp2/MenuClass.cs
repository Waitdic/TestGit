using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MenuClass
    {
        public void Menu()
        {
            int menuPoint = 0;
            Console.WriteLine("1) Constructor; \n0) Exit");
            Console.Write("Point: ");
            menuPoint = int.Parse(Console.ReadLine());
            Console.WriteLine(menuPoint);
            switch(menuPoint)
            {
                case 1:
                    
                        SampleConstructor sampCons = new SampleConstructor();
                        sampCons.Car();
                    break;
                
                default: Console.WriteLine("Its over!");
                    break;
            }
        }
    }
}
