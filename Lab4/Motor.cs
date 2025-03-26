using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Motor : Details
    {
        private double power;
        public double Power { get { return power; } }
        private int count_cylinders;
        public int Count_cylinders{get{ return count_cylinders; } }
        public Motor(string name, double weight, int count, double power, int count_cylinders) : base(name, weight, count)
        {
            this.power = power;
            this.count_cylinders = count_cylinders;
        }
    }
}
