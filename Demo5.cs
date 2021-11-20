using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    class Demo5
    {
        //public void Method()
        //{
        //    IList<int> integers = new List<int>()
        //    {
        //        5,
        //        10,
        //        15
        //    };
        //    for(int i = 0; i < integers.Count; i++)
        //    {
        //        Console.WriteLine(integers[i]);
        //    }
        //}

        public void Method()
        {
            IList<int> integers = new List<int>()
            {
                5,
                10,
                15
            };
            foreach (int integer in integers)
            {
                Console.WriteLine(integer);
            }
           
        }
    }
}
