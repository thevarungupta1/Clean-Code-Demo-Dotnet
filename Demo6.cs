using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    class Demo6
    {
        //public void Method()
        //{
        //    IList<int> integers = new List<int>();
        //    if(integers.Count > 0)
        //    {
        //        foreach(int i in integers)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        public void Method()
        {
            IList<int> integers = new List<int>();
           
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }          
        }
    }
}
