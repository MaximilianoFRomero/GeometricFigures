using GeometricFigures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Model
{
    internal class RegPoligon : ICalculate
    {
        private double side { get; set; }

        private int sideQuantity { get; set; }

        public RegPoligon(double side, int sideQuantity)
        {
            this.side = side;
            this.sideQuantity = sideQuantity;
        }

        public double CalculatePerimeter() 
        { 
            return side * sideQuantity; 
        }

        public double CotTheta() 
        {
            return 1 / Math.Tan(Math.PI / sideQuantity); 
        }

        public double CalculateArea() 
        {
            return 0.25 * sideQuantity * Math.Pow(side, 2) * CotTheta();
        }
    }
}
