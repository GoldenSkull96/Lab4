using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Wheel : Details
    {
        private double radius;
        public double Radius { get { return radius; } }
        private double tread_depth;
        public double TreadDepth { get { return tread_depth; } }
        public Wheel(string name, double weight, int count,double radius, double tread) :base( name, weight, count)
        {
            this.radius = radius;
            this.tread_depth = tread;
        }

    }
}
