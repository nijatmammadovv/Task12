using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Bus : Vehicle
    {
        public double motor;

        public Bus(string model)
        {
            this.model = model;
        }
        public Bus(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Bus(string model, string color, double motor) : this(model, color)
        {
            this.motor = motor;
        }
        public Bus(string model, string color, double motor, int passengersCount) : this(model, color, passengersCount)
        {
            this.passengersCount = passengersCount;
        }
        public Bus(string model, string color, double motor, int passengersCount, int cycle)
        {
            this.cycle = cycle;
        }
    }
}
