using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework
{
    struct Location
    {
        public double X;
        public double Y;
    }
    enum MovingType
    {
        Horizontal,
        Vertical
    }
    class Figure
    {
        private Location location;
        private ConsoleColor color;
        private bool visible;

        public Location Location { get => location; }
        public ConsoleColor Color { get => color; }
        public bool Visible { get => visible; }

        public void Move(MovingType movingType, double value) //метод передвижения по вертикали и горизонтали
        {
            if (movingType == 0)
            {
                location.X += value;
            }
            else
            {
                location.Y += value;
            }
        }

        public void SetColor(ConsoleColor color) //метод изменения цвета
        {
            this.color = color;
        }

        public void ChangeVisible() //метод изменения видимости
        {
            visible = !visible;
        }
    }
}
