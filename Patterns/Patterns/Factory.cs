using Patterns.Interfaces;

namespace Patterns.Patterns
{
    internal class Car : IFactory
    {
        void IFactory.Drive(int miles)
        {
            Console.WriteLine("Drive the car : {0} miles", miles);
        }
    }

    internal class Bike : IFactory
    {
        void IFactory.Drive(int miles)
        {
            Console.WriteLine("Drive the bike : {0} miles", miles);
        }
    }

    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }

    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string vehicle)
        {
            switch (vehicle)
            {
                case "Car":
                    return new Car();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", vehicle));
            }
        }
    }
}