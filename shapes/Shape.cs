using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Shape
    {
        private String name;
        private String color;
        private int noSide;

        public Shape() { }
        public Shape(String name, String color, int noSide) {
        
            this.Name = name;
            this.Color = color;
            this.NoSide = noSide;

        }

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int NoSide { get => noSide; set => noSide = value; }

        public override string ToString() 
        {
            return "Name: " + this.Name +
                "\nColor: " + this.Color +
                "\nNo of Side: " + this.NoSide;
        
        }

        public virtual double computeArea() {
            return 0.0;
        
        }

    }
}
