using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodTutorials
{
    abstract class Shape
    {
        public double length = 0.0;
        public double width = 0.0;
        public double radius = 0.0;

        public Shape(double radius)
        {
            this.radius = radius;
        }

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        //Make a virtual method
        public virtual void Area()
        {
           
        }
    }
}
