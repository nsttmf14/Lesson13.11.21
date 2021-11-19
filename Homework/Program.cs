using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 10.1");
            Console.WriteLine("Выберите фигуру: \n1.Прямоугольник\n2.Круг\n3.Точка");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Введите длину и высоту прямоугольника:");
                        double.TryParse(Console.ReadLine(), out double lenght);
                        double.TryParse(Console.ReadLine(), out double height);

                        Rectangle Rec = new Rectangle(lenght, height);

                        Console.WriteLine(Rec.GetSquare());

                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Введите радиус круга:");
                        double.TryParse(Console.ReadLine(), out double radius);
                        Circle Circ = new Circle(radius);
                        Console.WriteLine(Circ.GetSquare());
                        break;
                    }
                case "3":
                    {
                        Point Dot = new Point();
                        Console.WriteLine(Dot.GetSquare());
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
