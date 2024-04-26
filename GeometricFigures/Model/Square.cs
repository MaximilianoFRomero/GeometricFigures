using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Model
{
    internal class Square: ICalculate
    {
        private double side {  get; set; }

        public Square(double side) {
            
            this.side = side;
        }

        public double CalculatePerimeter() { return side * 4; }

        public double CalculateArea() { return side * side; }
    }
}
