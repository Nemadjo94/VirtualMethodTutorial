using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20, 15);
            rectangle.Area();

            Circle circle = new Circle(19);
            circle.Area();


        }
    }
}
