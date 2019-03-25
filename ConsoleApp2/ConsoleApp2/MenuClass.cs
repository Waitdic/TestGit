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
            Console.WriteLine("1) Конструктор; \n0) Екзит");
            Console.Write("Point: ");
            menuPoint = int.Parse(Console.ReadLine());
            Console.WriteLine(menuPoint);
            switch(menuPoint)
            {
                case 1:
                    
                        SampleConstructor sampCons = new SampleConstructor();
                        sampCons.Car();
                    break;
                
                default: Console.WriteLine("Это конеЦ!");
                    break;
            }
        }
    }
}
