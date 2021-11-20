using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // without DI
    //class Tyre
    //{

    //}
    //class Engine
    //{

    //}
    //class Car
    //{
    //    Engine engine;
    //    Tyre tyre;
    //    public Car()
    //    {
    //        this.engine = new Engine();
    //        this.tyre = new Tyre();
    //    }
    //}

    // with DI
    class Tyre
    {
        public Tyre(string type)
        {

        }

    }
    class Engine
    {
        public Engine(string type)
        {

        }
    }

  

    class Car
    {
        Engine engine;
        Tyre tyre;
        public Car(Engine engine, Tyre tyre)
        {
            this.engine = engine;
            this.tyre = tyre;
        }
    }







    class Demo13
    {
    }
}
