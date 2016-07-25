using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dealership.Engine
{
    public sealed class DealershipEngine : IEngine
    {
        // Commands constants
        private const string InvalidCommand = "Invalid command!";

        private const string UserAlreadyExist = "User {0} already exist. Choose a different username!";
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string UserRegisterеd = "User {0} registered successfully!";
        private const string UserNotLogged = "You are not logged! Please login first!";
        private const string NoSuchUser = "There is no user with username {0}!";
        private const string UserLoggedOut = "You logged out!";
        private const string UserLoggedIn = "User {0} successfully logged in!";
        private const string WrongUsernameOrPassword = "Wrong username or password!";
        private const string YouAreNotAnAdmin = "You are not an admin!";

        private const string CommentAddedSuccessfully = "{0} added comment successfully!";
        private const string CommentRemovedSuccessfully = "{0} removed comment successfully!";

        private const string VehicleRemovedSuccessfully = "{0} removed vehicle successfully!";
        private const string VehicleAddedSuccessfully = "{0} added vehicle successfully!";

        private const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        private const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";

        private const string CommentDoesNotExist = "The comment does not exist!";
        private const string VehicleDoesNotExist = "The vehicle does not exist!";

        private static readonly IEngine SingleInstance = new DealershipEngine();

        private IDealershipFactory factory;
        private ICollection<IUser> users;
        private IUser loggedUser;

        private DealershipEngine()
        {
            this.factory = new DealershipFactory();
            this.users = new List<IUser>();
            this.loggedUser = null;
        }

        public static IEngine Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        public void Reset()
        {
            this.factory = new DealershipFactory();
            this.users = new List<IUser>();
            this.loggedUser = null;
            var commands = new List<ICommand>();
            var commandResult = new List<string>();
            this.PrintReports(commandResult);
        }


        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = Console.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = new Command(currentLine);
                commands.Add(currentCommand);

                currentLine = Console.ReadLine();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.ProcessSingleCommand(command);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            Console.Write(output.ToString());
        }

        private string ProcessSingleCommand(ICommand command)
        {
            if (command.Name != "RegisterUser" && command.Name != "Login")
            {
                if (this.loggedUser == null)
                {
                    return UserNotLogged;
                }
            }

            switch (command.Name)
            {
                case "RegisterUser":
                    var username = command.Parameters[0];
                    var firstName = command.Parameters[1];
                    var lastName = command.Parameters[2];
                    var password = command.Parameters[3];

                    var role = Role.Normal;

                    if (command.Parameters.Count > 4)
                    {
                        role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
                    }

                    return this.RegisterUser(username, firstName, lastName, password, role);

                case "Login":
                    username = command.Parameters[0];
                    password = command.Parameters[1];

                    return this.Login(username, password);

                case "Logout":
                    return this.Logout();

                case "AddVehicle":
                    var type = command.Parameters[0];
                    var make = command.Parameters[1];
                    var model = command.Parameters[2];
                    var price = decimal.Parse(command.Parameters[3]);
                    var additionalParam = command.Parameters[4];

                    var typeEnum = (VehicleType)Enum.Parse(typeof(VehicleType), type, true);

                    return this.AddVehicle(typeEnum, make, model, price, additionalParam);

                case "RemoveVehicle":
                    var vehicleIndex = int.Parse(command.Parameters[0]) - 1;

                    return this.RemoveVehicle(vehicleIndex);

                case "AddComment":
                    var content = command.Parameters[0];
                    var author = command.Parameters[1];
                    vehicleIndex = int.Parse(command.Parameters[2]) - 1;

                    return this.AddComment(content, vehicleIndex, author);

                case "RemoveComment":
                    vehicleIndex = int.Parse(command.Parameters[0]) - 1;
                    var commentIndex = int.Parse(command.Parameters[1]) - 1;
                    username = command.Parameters[2];

                    return this.RemoveComment(vehicleIndex, commentIndex, username);

                case "ShowUsers":

                    return this.ShowAllUsers();

                case "ShowVehicles":
                    username = command.Parameters[0];

                    return this.ShowUserVehicles(username);

                default:
                    return string.Format(InvalidCommand, command.Name);
            }
        }

        private string RegisterUser(string username, string firstName, string lastName, string password, Role role)
        {
            if (this.loggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.loggedUser.Username);
            }

            if (this.users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(UserAlreadyExist, username);
            }

            var user = this.factory.CreateUser(username, firstName, lastName, password, role.ToString());
            this.loggedUser = user;
            this.users.Add(user);

            return string.Format(UserRegisterеd, username);
        }

        private string Login(string username, string password)
        {
            if (this.loggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.loggedUser.Username);
            }

            var userFound = this.users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                this.loggedUser = userFound;
                return string.Format(UserLoggedIn, username);
            }

            return WrongUsernameOrPassword;
        }

        private string Logout()
        {
            this.loggedUser = null;
            return UserLoggedOut;
        }

        private string AddVehicle(VehicleType type, string make, string model, decimal price, string additionalParam)
        {
            IVehicle vehicle = null;

            if (type == VehicleType.Car)
            {
                vehicle = this.factory.CreateCar(make, model, price, int.Parse(additionalParam));
            }
            else if (type == VehicleType.Motorcycle)
            {
                vehicle = this.factory.CreateMotorcycle(make, model, price, additionalParam);
            }
            else if (type == VehicleType.Truck)
            {
                vehicle = this.factory.CreateTruck(make, model, price, int.Parse(additionalParam));
            }

            this.loggedUser.AddVehicle(vehicle);

            return string.Format(VehicleAddedSuccessfully, this.loggedUser.Username);
        }

        private string RemoveVehicle(int vehicleIndex)
        {
            ValidateRange(vehicleIndex, 0, this.loggedUser.Vehicles.Count, RemovedVehicleDoesNotExist);

            var vehicle = this.loggedUser.Vehicles[vehicleIndex];

            this.loggedUser.RemoveVehicle(vehicle);

            return string.Format(VehicleRemovedSuccessfully, this.loggedUser.Username);
        }

        private string AddComment(string content, int vehicleIndex, string author)
        {
            var comment = this.factory.CreateComment(content);
            comment.Author = this.loggedUser.Username;
            var user = this.users.FirstOrDefault(u => u.Username == author);

            if (user == null)
            {
                return string.Format(NoSuchUser, author);
            }

            ValidateRange(vehicleIndex, 0, user.Vehicles.Count, VehicleDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];

            this.loggedUser.AddComment(comment, vehicle);

            return string.Format(CommentAddedSuccessfully, this.loggedUser.Username);
        }

        private string RemoveComment(int vehicleIndex, int commentIndex, string username)
        {
            var user = this.users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            ValidateRange(vehicleIndex, 0, user.Vehicles.Count, RemovedVehicleDoesNotExist);
            ValidateRange(commentIndex, 0, user.Vehicles[vehicleIndex].Comments.Count, RemovedCommentDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];
            var comment = user.Vehicles[vehicleIndex].Comments[commentIndex];

            this.loggedUser.RemoveComment(comment, vehicle);

            return string.Format(CommentRemovedSuccessfully, this.loggedUser.Username);
        }

        private string ShowAllUsers()
        {
            if (this.loggedUser.Role != Role.Admin)
            {
                return YouAreNotAnAdmin;
            }

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in this.users)
            {
                builder.AppendLine(string.Format("{0}. {1}", counter, user.ToString()));
                counter++;
            }

            return builder.ToString().Trim();
        }

        private string ShowUserVehicles(string username)
        {
            var user = this.users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            return user.PrintVehicles();
        }

        private static void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
