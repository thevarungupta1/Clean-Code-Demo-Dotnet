using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // indentation
    //class     Demo7
    //{
    //    public void Method(
    //        int argumnet)
    //    {
    //        string text = "text";
    //                  text = text + argumnet;
    //    }
    //}

    class Demo7
    {
        public void Method(int argumnet)
        {
            string text = "text";
            text = text + argumnet;
        }
    }
}
