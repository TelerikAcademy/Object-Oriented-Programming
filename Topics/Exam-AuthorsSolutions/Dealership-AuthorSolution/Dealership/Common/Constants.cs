namespace Dealership.Common
{
    public class Constants
    {
        // String lengths
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int MinPasswordLength = 5;
        public const int MaxPasswordLength = 30;
        public const int MinCategoryLength = 3;
        public const int MaxCategoryLength = 10;
        public const int MinMakeLength = 2;
        public const int MaxMakeLength = 15;
        public const int MinModelLength = 1;
        public const int MaxModelLength = 15;
        public const int MinCommentLength = 3;
        public const int MaxCommentLength = 200;

        // Numbers validation
        public const int MinWheels = 2;
        public const int MaxWheels = 10;
        public const decimal MinPrice = 0.0m;
        public const decimal MaxPrice = 1000000.0m;
        public const int MinSeats = 1;
        public const int MaxSeats = 10;
        public const int MinCapacity = 1;
        public const int MaxCapacity = 100;

        // Strings for validation
        public const string StringMustBeBetweenMinAndMax = "{0} must be between {1} and {2} characters long!";
        public const string NumberMustBeBetweenMinAndMax = "{0} must be between {1} and {2}!";

        // Vehicle max to add if not VIP
        public const int MaxVehiclesToAdd = 5;

        // Username pattern
        public const string UsernamePattern = "^[A-Za-z0-9]+$";
        public const string PasswordPattern = "^[A-Za-z0-9@*_-]+$";

        // Strings for vehicles, comments and users
        public const string InvalidSymbols = "{0} contains invalid symbols!";

        public const string UserToString = "Username: {0}, FullName: {1} {2}, Role: {3}";

        public const string CommentCannotBeNull = "Comment cannot be null!";
        public const string VehicleCannotBeNull = "Vehicle cannot be null!";

        public const string NotAnVipUserVehiclesAdd = "You are not VIP and cannot add more than {0} vehicles!";
        public const string AdminCannotAddVehicles = "You are an admin and therefore cannot add vehicles!";

        public const string YouAreNotTheAuthor = "You are not the author!";
        public const string UserCannotBeNull = "User cannot be null!";

        // Added additionally
        public const string PropertyCannotBeNull = "{0} cannot be null!";

    }
}
