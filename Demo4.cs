using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // Exception handling
    class Demo4
    {
        //public void Method()
        //{
        //    object someObj = MethodWithReturn(false);
        //    if (someObj is string)
        //        Console.WriteLine("yes");
        //    else if (someObj is Exception)
        //        Console.WriteLine("no");
        //}

        //public object MethodWithReturn(bool argument)
        //{
        //    if (argument)
        //        return string.Empty;
        //    else
        //        return new Exception();
        //}

        public void Method()
        {
            try
            {
                if (MethodWithReturn(false) is string)
                    Console.WriteLine("yes");
            }
            catch
            {
                Console.WriteLine("no");
            }
        }

        public object MethodWithReturn(bool argument)
        {
            if (argument)
                return string.Empty;
            throw new Exception();
        }
    }
}
