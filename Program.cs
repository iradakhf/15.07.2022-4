using System;
namespace ConsoleApp45
{
    class Program
    {
        public static void Main (string[] args)
        {
            //creating reference of Shape class which refers to Square class instance

            AbstractClassShape abstractClass = new Square(4);
       

            Console.WriteLine(abstractClass.area() ); 
        }
    }
}