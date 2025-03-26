using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Car
    {
        public readonly string Name;
        public readonly string Model;
        private Motor motor;
        public Motor Motor { get { return motor; } }
        private Wheel wheels;
        public Wheel Wheels { get { return wheels; } }
        private Tank tank;
        public Tank Tank { get { return tank; } }
        public Car(string Name, string Model, Motor motor, Wheel wheels, Tank tank)
        {
            this.Model = Model;
            this.Name = Name;
            this.motor = motor;
            this.wheels = wheels;
            this.tank = tank;
        }
        public void Riding(double range)
        {
            tank.riding(range);
            Console.WriteLine($"Колесом было сделано: {(range*1000)/(2*Math.PI*wheels.Radius):F2} оборотов");
        }
    }
}
