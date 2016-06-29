namespace Societies.ConsoleClient
{
    using Core.Contracts;
    using Core.Infrastructure.Enumerations.Human;
    using Core.Infrastructure.Utils;
    using Core.Models.Buildings;
    using Core.Models.Common;
    using Core.Models.Humans;
    using Core.Models.Humans.Abstract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        static void Main(string[] args)
        {
            IWaiter waiter = 
                new Waiter(
                    DataGenerator.GenerateMaleName(),
                    DataGenerator.GenerateAge(),
                    HairColorType.Blue,
                    EyesColorType.Brown,
                    FaceShapeType.Heart,
                    RaceType.European,
                    GenderType.Male,
                    ReligionType.Hinduism);

            IHuman softwareEngineer =
                new SoftwareEngineer(
                    DataGenerator.GenerateMaleName(),
                    DataGenerator.GenerateAge(),
                    HairColorType.Brown,
                    EyesColorType.Green,
                    FaceShapeType.Diamond,
                    RaceType.Indian,
                    GenderType.Male,
                    ReligionType.Christianity);

            IHuman standardHuman =
                new Human(
                    DataGenerator.GenerateFemaleName(),
                    DataGenerator.GenerateAge(),
                    HairColorType.Brown,
                    EyesColorType.Green,
                    FaceShapeType.Diamond,
                    RaceType.African,
                    GenderType.Female,
                    ReligionType.Agnosticism);

            // Work to make some money
            softwareEngineer.Work(10);
            softwareEngineer.Work(9);
            softwareEngineer.Work(14);
            softwareEngineer.Work(11);

            standardHuman.Work(7);
            standardHuman.Work(8);
            standardHuman.Work(9);
            standardHuman.Work(8);

            var restaurantCapacity = 120;
            var restaurantName = "Wailey's Restaurant";
            var restaurantAddress = "Malibu street, 147";
            IRestaurantBuilding restaurant =
                new RestaurantBuilding(
                    restaurantName,
                    restaurantAddress,
                    restaurantCapacity);

            restaurant.HireWaiter(waiter);
            restaurant.AcceptClient(softwareEngineer);
            restaurant.AcceptClient(standardHuman);

            restaurant.ProcessClientRequests();
        }
    }
}
