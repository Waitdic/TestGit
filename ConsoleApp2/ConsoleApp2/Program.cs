﻿using System;
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
            Console.WriteLine("Пожалуйста введите номер: ");
            //menuPoint = Console.Read();
            MenuClass M = new MenuClass();
            M.Menu();
            Console.ReadKey();
        }
    }
}