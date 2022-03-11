using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Bicycle: Vehicle
    {
        public Bicycle (string model)
        {
            this.model = model;
        }
        public Bicycle(string model, string color) : this(model)
        {
            this.color = color;
        }
        public Bicycle(string model, string color, int passengersCount) : this(model, color)
        {
            this.passengersCount = passengersCount;
        }
        public Bicycle(string model, string color, int passengersCount, int cycle)
        {
            this.cycle = cycle;
        }
    }
}
