using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // better construction
    class Demo3
    {
        //public void Method(bool boolen, int integer)
        //{
        //    if (boolen)
        //    {
        //        Console.WriteLine("true");
        //    }
        //    else
        //    {
        //        if(integer > 0)
        //        {
        //            Console.WriteLine("positive");
        //        }
        //    }
        //}

        public void Method(bool boolean, int integer)
        {
            if (boolean)
                Console.WriteLine("true");
            else if (integer > 0)
                Console.WriteLine("positive");
        }
    }
}
