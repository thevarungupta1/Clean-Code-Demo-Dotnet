using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    public interface ICar
    {
        void GetCarMoodel();
        void GetColor();
    }

    public class Audi : ICar
    {
        public void GetCarMoodel()
        {
            Console.WriteLine("Audi A6");
        }

        public void GetColor()
        {
            Console.WriteLine("Black");
        }
    }

    public class Honda : ICar
    {
        public void GetCarMoodel()
        {
            Console.WriteLine("Honda City");
        }

        public void GetColor()
        {
            Console.WriteLine("White");
        }
    }

    public class BMW : ICar
    {
        public void GetCarMoodel()
        {
            Console.WriteLine("5 Series");
        }

        public void GetColor()
        {
            Console.WriteLine("Red");
        }
    }

    public class CarFactory
    {
        public static ICar GetCarInstance(CarEnum carEnum)
        {
            switch ((int)carEnum)
            {
                case 1:
                    return new Audi();
                case 2:
                    return new Honda();
                case 3:
                    return new BMW();
                default:
                    return null;
            }
        }
    }

    public enum CarEnum
    {
        Audu = 1,
        Honda = 2,
        BMW = 3
    }

    class Demo15
    {
        public static void Main()
        {
            //Audi car = new Audi();
            //car.GetCarMoodel();
            //car.GetColor();

            //Honda car2 = new Honda();
            //car2.GetCarMoodel();
            //car2.GetColor();

            ICar car1 = CarFactory.GetCarInstance(CarEnum.BMW);
            car1.GetCarMoodel();
            car1.GetColor();

            

            Console.ReadKey();
        }
    }
}
