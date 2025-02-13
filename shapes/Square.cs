using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Square : Shape
    {
        private double length;


        public Square() { }

        public Square(double length)
        {
            this.Length = length;
        }

        public double Length { get => length; set => length = value; }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo of Side: " + this.NoSide +
                "\nLength: " + this.Length;
        }

        public override double computeArea()
        {
            return Math.Pow(this.Length, 2);
        }
        public double computePerimeter()
        {
            return 4 * this.Length;
        }

    }
}
