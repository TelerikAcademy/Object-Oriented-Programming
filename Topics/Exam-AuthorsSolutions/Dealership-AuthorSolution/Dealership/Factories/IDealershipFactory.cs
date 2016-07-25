using Dealership.Contracts;

namespace Dealership.Factories
{
    public interface IDealershipFactory
    {
        IUser CreateUser(string username, string firstName, string lastName, string password, string role);

        IComment CreateComment(string content);

        IVehicle CreateCar(string make, string model, decimal price, int seats);

        IVehicle CreateMotorcycle(string make, string model, decimal price, string category);

        IVehicle CreateTruck(string make, string model, decimal price, int weightCapacity);
    }
}
