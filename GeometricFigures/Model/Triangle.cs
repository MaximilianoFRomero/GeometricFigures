using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Model
{
    internal class Triangle : ICalculate
    {
        private double side1 { get; set; }

        private double side2 { get; set; }

        private double side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculatePerimeter() 
        { 
            return side1 + side2 + side3; 
        }

        public double CalculateArea() 
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return area;
        }
    }
}

