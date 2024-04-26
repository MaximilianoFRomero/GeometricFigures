using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Model
{
    internal class Circle : ICalculate
    {
        private double radio { get; set; }

        public Circle(double radio) 
        {
            this.radio = radio;
        }

        public double CalculateArea()
        {
            return Math.PI*(radio*radio);
        }

        public double CalculatePerimeter()
        {
            return  2*Math.PI*radio;
        }
    }
}
