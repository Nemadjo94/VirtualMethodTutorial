using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodTutorials
{
    class Rectangle : Shape
    {
        public Rectangle(double length, double width) : base(length, width)
        {

        }

        //Override the Area method from Shape class
        public override void Area()
        {
            double area = length * width;
            Console.WriteLine("Area of Rectangle is: {0:0.00}", area);
        }
    }
}
