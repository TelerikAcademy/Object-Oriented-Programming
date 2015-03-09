public class UserProfile
{
	public int UserId { get; private set; }
	public string FirstName { get; private set; }
	public string LastName { get; private set; }

	public UserProfile(int userId, string firstName, string lastName)
	{
		this.UserId = userId;
		this.FirstName = firstName;
		this.LastName = lastName;
	}

	public override string ToString()
	{
		return string.Format("Id: {0}, First name: {1}, Last name: {2}",
			this.UserId, this.FirstName, this.LastName);
	}
}
