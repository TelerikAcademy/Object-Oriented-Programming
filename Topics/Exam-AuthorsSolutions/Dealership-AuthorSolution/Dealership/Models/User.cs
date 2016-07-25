using Dealership.Contracts;
using System;
using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Common;
using System.Text;

namespace Dealership.Models
{
    public class User : IUser
    {
        private const string UsernameProperty = "Username";
        private const string FirstNameProperty = "Firstname";
        private const string LastNameProperty = "Lastname";
        private const string PasswordProperty = "Password";
        private const string NoVehiclesHeader = "--NO VEHICLES--";
        private const string UserHeader = "--USER {0}--";

        private readonly string firstName;
        private readonly string lastName;
        private readonly string username;
        private readonly string password;

        public User(string username, string firstName, string lastName, string password, Role role)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.Role = role;
            this.Vehicles = new List<IVehicle>();

            this.ValidateFields();
        }

        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role { get; private set; }

        public IList<IVehicle> Vehicles { get; private set; }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            Validator.ValidateNull(commentToAdd, Constants.CommentCannotBeNull);
            Validator.ValidateNull(vehicleToAddComment, Constants.CommentCannotBeNull);

            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            if (this.Role == Role.Normal && this.Vehicles.Count >= 5)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }

            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }

            this.Vehicles.Add(vehicle);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            Validator.ValidateNull(vehicleToRemoveComment, Constants.VehicleCannotBeNull);
            Validator.ValidateNull(commentToRemove, Constants.CommentCannotBeNull);

            if (this.Username != commentToRemove.Author)
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }

            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            this.Vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            return string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName, this.Role);
        }

        public string PrintVehicles()
        {
            var builder = new StringBuilder();

            var counter = 1;
            builder.AppendLine(string.Format(UserHeader, this.Username));

            if (this.Vehicles.Count <= 0)
            {
                builder.AppendLine(NoVehiclesHeader);
            }
            else
            {
                foreach (var vehicle in this.Vehicles)
                {
                    builder.AppendLine(string.Format("{0}. {1}", counter, vehicle.ToString()));
                    counter++;
                }
            }

            return builder.ToString().Trim();
        }

        private void ValidateFields()
        {
            Validator.ValidateNull(this.username, string.Format(Constants.PropertyCannotBeNull, UsernameProperty));
            Validator.ValidateSymbols(this.username, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, UsernameProperty));
            Validator.ValidateIntRange(this.username.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, UsernameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.firstName, string.Format(Constants.PropertyCannotBeNull, FirstNameProperty));
            Validator.ValidateIntRange(this.firstName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, FirstNameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.lastName, string.Format(Constants.PropertyCannotBeNull, LastNameProperty));
            Validator.ValidateIntRange(this.lastName.Length, Constants.MinNameLength, Constants.MaxNameLength, string.Format(Constants.StringMustBeBetweenMinAndMax, LastNameProperty, Constants.MinNameLength, Constants.MaxNameLength));

            Validator.ValidateNull(this.password, string.Format(Constants.PropertyCannotBeNull, PasswordProperty));
            Validator.ValidateSymbols(this.password, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, PasswordProperty));
            Validator.ValidateIntRange(this.password.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength, string.Format(Constants.StringMustBeBetweenMinAndMax, PasswordProperty, Constants.MinPasswordLength, Constants.MaxPasswordLength));
        }
    }
}
