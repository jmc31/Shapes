using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Triangle:Shape
    {
        private double base1;
        private double height;

        public Triangle() { }

        public Triangle(double base1, double height) { 
        
                this.Base1 = base1;
                this.height = height;
        }

        public double Height { get => height; set => height = value; }
        public double Base1 { get => base1; set => base1 = value; }

        public override string ToString()
        {
            return "Name: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo of Side: " + this.NoSide +
                "\nLRadius: " + this.Base1 +
                "\nHeight: " + this.Height;
        }

        public override double computeArea()
        {
            return 0.5 * this.Base1 * this.Height;
        }
    }
}
