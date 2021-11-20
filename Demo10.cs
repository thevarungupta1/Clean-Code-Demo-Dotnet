using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemos
{
    // open and close principle

    //public class Rectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }
    //}

    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}

    //public class AreaCalculator
    //{
    //    public double TotalArea(object[] objArray)
    //    {
    //        double area = 0.0;
    //        Rectangle objRectangle;
    //        Circle objCircle;
    //        foreach(var obj in objArray)
    //        {
    //            if (obj is Rectangle) 
    //            {
    //                area += obj.Width + obj.Width;
    //            }
    //            else
    //            {
    //                objCircle = (Circle)obj;
    //                area += objCircle.Radius * objCircle.Radius * Math.PI;
    //            }
                
    //        }
    //        return area;
    //    }
    //}

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle: Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }




    class Demo10
    {
    }
}
