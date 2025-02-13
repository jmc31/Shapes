using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Rectangle : Shape
    {

        private double length;
        private double width;

        public Rectangle() { }

        public Rectangle(double length, double width)
        {
            this.Name = Name;
            this.Color = Color;
            this.NoSide = NoSide;
            this.Length = length;
            this.Width = width;
        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo of Side: " + this.NoSide +
                "\nLength: " + this.Length +
                "\nWidth: " + this.Width;
        }

        public override double computeArea () 
        {
            return this.Length*this.Width;
        }
        //public override double computePerimeter() {
        //    return 2 * (this.Length + this.Width);
        //}
    }
}
