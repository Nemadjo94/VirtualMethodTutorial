using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodTutorials
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius)
        {

        }

        //Override the Area method from Shape class
        public override void Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Circle is: {0:0.00}", area);
        }
    }
}
