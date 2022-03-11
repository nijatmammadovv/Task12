using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car("Mersedes", "Blue", 2.3, 4, 4);
            Bus theBus = new Bus("Mikroavtobus", "Red", 2.1,4,3);
            Bicycle theBicycle = new Bicycle("Dag velosipedi", "Black", 2, 1);
            
            Console.WriteLine(theBus.model+ " " + theBus.color);
            Console.WriteLine(theBus.motor+ " " + theBus.passengersCount + " "+ theBus.cycle);
            
        }
    }
}
