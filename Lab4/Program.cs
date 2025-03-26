using Lab4;

Motor motor = new Motor("motor", 165, 1, 112200, 4);
Wheel wheel = new Wheel("wheels", 15, 4, 0.464, 20.0);
Tank tank = new Tank("tank", 10, 1, 96, 48);
Car car = new Car("Уаз", "Буханка", motor, wheel, tank);
car.Riding(15);
car.Tank.refueling(200);
Console.WriteLine(car.Name + " " + car.Model);