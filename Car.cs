using System;
using System.Collections.Generic;
using System.Text;

namespace Hw29_Paterns
{
    
    class Trakrot : CarDoing
    {
        public override void AddBox()
        {
            Do.box = new Box() { Name = "Автомат" };
        }

        public override void AddWheels()
        {
            Do.wheels = new Wheels() { Name = "Для тракторов(большие)" };
        }

        public override void AddMotor()
        {
            Do.motor = new Motor() { Name = "360 л.c" };
        }

        public override void AddBody()
        {
            Do.body = new Body() { Name = "Алюминивое" };
        }
    }
    class Mechanik
    {
        public CarDoing Make(CarBuilder carBuilder)
        {
            carBuilder.AddBox();
            carBuilder.AddWheels();
            carBuilder.AddMotor();
            carBuilder.AddBody();
            return carBuilder.Do;
        }
    }
    abstract class CarBuilder
    {
        public CarDoing Do { get; set; }
        public void CreateDrink()
        {
            Do = new CarDoing();
        }
        public abstract void AddBox();
        public abstract void AddWheels();
        public abstract void AddMotor();
        public abstract void AddBody();

    }
    class CarDoing
    {
        public Box box { get; set; }
        public Wheels wheels { get; set; }
        public Motor motor { get; set; }
        public Body body { get; set; }
        public override string ToString()
        {
            string result = box.Name + Environment.NewLine +
                wheels.Name + Environment.NewLine +
                motor.Name + Environment.NewLine +
                body.Name + Environment.NewLine;
            return result;
        }
    }
    class Box
    {
        public string Name { get; set; }
    }
    class Wheels
    {
        public string Name { get; set; }
    }

    class Motor
    {
        public string Name { get; set; }
    }

    class Body
    {
        public string Name { get; set; }
    }
}
