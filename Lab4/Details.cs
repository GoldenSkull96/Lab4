using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Details
    {
        private double weight;
        public double Weight { get { return weight; } }
        private string name;
        public string Name { get { return name; } }
        private int count;
        public int Count { get { return count; } }
        public Details(string name, double weight, int count)
        {
            this.name = name;
            this.weight = weight;
            this.count = count;
        }
    }
}
