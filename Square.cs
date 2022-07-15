using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal class Square : AbstractClassShape
    {
        //private data member
        private int side;

        //method of Square class

        public Square (int x = 0)
        {
            side = x;
        }
        //overriding of the abstract method of Shape class using the override keyword

        public override int area()
        {
            Console.WriteLine("Area of Square: ");
            return (side * side);

        }
    }
}
