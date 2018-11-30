using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6;

namespace HomeWork
{
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            Building house = new Building(2, 2500, 4); //создаю объект типа Building
            Building office = new Building(3, 4500, 25);
            
            Console.WriteLine($"Максимальное количество человек в доме,\n если на каждого должно приходится 300 кв.м. {house.MaxOccupant(500)}");
            
            Console.WriteLine();

            Console.WriteLine($"Максимальное количество человек в оффисе,\n если на каждого должно приходится 300 кв.м. {office.MaxOccupant(300)}");

            Console.WriteLine();

            HomeLive family = new HomeLive();

            IEat[] eats = new IEat[] { new Dad(), new Mom(), new Son() };
            Console.WriteLine("Семья ест");
            family.allEat(eats);
        }
    }
}
