using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Controllers
{
    internal class FigureController
    {
        private List<ICalculate> figures;
        public FigureController()
        {
            figures = new List<ICalculate>();
        }

        public void NewFigure(ICalculate iFigure)
        {
            figures.Add(iFigure);
        }

        public List<ICalculate> ListFigure()
        {
            return figures;
        }

        public override string ToString()
        {
            return figures.Count().ToString();
        }


    }
}
