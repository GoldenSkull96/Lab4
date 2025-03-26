using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Tank : Details
    {
        private double max_volume;
        public double max_Volume { get { return max_volume; } }
        private double current_volume;
        public double current_Volume { get { return current_volume; } }
        public Tank(string name, double weight, int count, double max_volume, int current_volume) : base(name, weight, count)
        {
            this.max_volume = max_volume;
            this.current_volume = current_volume;
        }
        public void refueling(double volume)
        {
            if((max_volume - (current_volume + volume)) < 0)
            {
                Console.WriteLine("Бак полностью заправлен");
                Console.WriteLine($"Было утеряно {Math.Abs(max_volume - (current_volume + volume)):F2} литров");
                current_volume = max_volume;
                return;
            }
            else
            {
                current_volume += volume;
                Console.WriteLine($"Текущая заполненность бака: {current_volume:F2} литров");
                return;
            }
        }
        public void riding(double range)
        {
            current_volume -= range * 0.15;
            Console.WriteLine($"За езду на {range:F2} км было потрачено литров {range * 0.13:F2}");
            Console.WriteLine($"Текущая заполненность бака: {current_volume:F2} литров");
        }
    }
}
