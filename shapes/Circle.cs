using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Circle:Shape
    {
        private double radius;
        public Circle() { }

        public Circle(double radius) {
        this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo of Side: " + this.NoSide +
                "\nLRadius: " + this.radius;
        }

        public override double computeArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
