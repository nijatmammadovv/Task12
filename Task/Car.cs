using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Car:Vehicle
    {
        public double motor;

        public Car(string model)
        {
            this.model = model;
        }
        public Car(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Car(string model, string color, double motor):this(model,color)
        {
            this.motor = motor;
        }
        public Car(string model, string color, double motor, int passengersCount):this(model,color,passengersCount)
        {
            this.passengersCount = passengersCount;
        }
        public Car(string model, string color, double motor, int passengersCount, int cycle)
        {
            this.cycle = cycle;
        }
    }
}
