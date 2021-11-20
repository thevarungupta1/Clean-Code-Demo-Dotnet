using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    class Demo2
    {
        //public delegate void LoginEventHandler(object sender, EventArgs e);
        //public event LoginEventHandler LoginEvent;

        //public void Method()
        //{
        //    if(LoginEvent ! = null)
        //    {
        //        LoginEvent.Invoke(this, new EventArgs());
        //    }
        //}
        public event EventHandler LoginEvent;
        public void Method()
        {
            LoginEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
