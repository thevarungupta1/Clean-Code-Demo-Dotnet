using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
   
    class Demo1
    {

        //public void Method()
        //{
        //    int integer = 5;
        //    string text = "text ";
        //    string trimmedText = text.Trim();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        integer = integer + i;
        //    }
        //    trimmedText = trimmedText + integer;
        //}

        public void Method()
        {
            int integer = 5;
            string text = "text ".Trim();
            
            for (int i = 0; i < 10; i++)
            {
                integer = integer + i;
            }
            text = text + integer;
        }



        static void Main2(string[] args)
        {
        }
    }
}
