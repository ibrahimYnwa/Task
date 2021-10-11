using System;

namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "White", 280, 10, 60);
            car.QunatityofKilometr();
            car.Run();
            car.howManyFuelareEnough(100);






            
        }

        
    }
}
