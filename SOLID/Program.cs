using System;
using System.Collections.Generic;

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[]
            {
                new Rectangle { Height = 10, Width = 5 }
            };


            AreaCalculation areaCalculation = new AreaCalculation();
            Console.WriteLine(areaCalculation.TotalArea(rectangles));
            //Console.WriteLine("Hello World!");
        }
    }
}
