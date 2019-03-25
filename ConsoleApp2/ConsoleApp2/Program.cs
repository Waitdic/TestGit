using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Programm
    {
        static void Main(string[] args)
        {
            //int menuPoint;
            Console.WriteLine("Please, enter menu number: ");
            //menuPoint = Console.Read();
            MenuClass M = new MenuClass();
            M.Menu();
            Console.ReadKey();
        }
    }
}
