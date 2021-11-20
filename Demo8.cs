using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    class Demo8
    {
        //public int Method()
        //{
        //    bool usePassword = true;
        //    if (usePassword)
        //        return 5;
        //    else
        //        return -2;
        //    return -1;
        //}

        public enum State
        {
            Valid = 5,
            InValid = -1
        }

        public State Method()
        {
            return State.Valid;
        }
    }
}
