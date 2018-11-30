using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class HomeLive
    {
        public void allEat(IEat[] arr)
        {
            for (int i = 0; i < arr.Count(); i++)
                arr[i].eat();
        }
    }
}
