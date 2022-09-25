using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * 3.1416;
        }
    }

    public class AreaCalculation
    {
        public double TotalArea(Shape[] shapes)
        {
            double totalArea = 0;
            foreach (var item in shapes)
            {
                totalArea += item.Area();
            }
            return totalArea;
        }
    }

}
