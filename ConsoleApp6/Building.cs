using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Building
    {
        public int Floors; //количество этажей 
        public int Area; //общая площадь здания
        public int Occupants; // количество жильцов

        public Building(int f, int a, int o) //конструктор 
        {
            Floors = f;
            Area = a;
            Occupants = o;
        }

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
        /* возвращает максимальное количество человек
         * занимающих здание */
        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }
}
