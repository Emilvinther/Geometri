using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private double sidea;

        public double Sidea { get => sidea; set => sidea = value; }

        public Square()
        {

        }

        public Square(double sidea)
        {
            Sidea = sidea;
        }
        
        public double Perimitor()
        {
            return sidea + sidea + sidea + sidea;
        }

        public double Area()
        {
            return sidea * sidea;
        }
    }
}
