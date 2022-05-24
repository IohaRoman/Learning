namespace Learning.Interfaces
{
    internal class Car : IVehiculo
    {
        public int fuel { get; set; }

        public Car(int fuel)
        {
            this.fuel = fuel;
        }

        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Car Driving");
            }
            else Console.WriteLine("Not enough fuel");
        }

        public bool Refuel(int fuelCount)
        {
            fuel += fuelCount;

            return true;
        }
    }
}