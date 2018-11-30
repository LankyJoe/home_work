using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface IEat
    {
        void eat();
    }

    class Dad : IEat
    {
       public void eat()
        {
            Console.WriteLine("Отец ест");
        } 
    }

    class Mom : IEat
    {
        public void eat()
        {
            Console.WriteLine("Мама ест");
        }
    }

    class Son : IEat
    {
        public void eat()
        {
            Console.WriteLine("Сын ест");
        }
    }
}
