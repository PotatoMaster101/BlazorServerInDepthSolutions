namespace Components.Data;

public class User
{
    public string FirstName { get; }

    public string LastName { get; }

    public string DisplayName { get; set; }

    public User(string firstname, string lastname)
    {
        if (string.IsNullOrWhiteSpace(firstname))
            throw new ArgumentException(nameof(string.IsNullOrWhiteSpace), nameof(firstname));
        if (string.IsNullOrWhiteSpace(lastname))
            throw new ArgumentException(nameof(string.IsNullOrWhiteSpace), nameof(lastname));

        FirstName = firstname;
        LastName = lastname;
        DisplayName = $"{firstname} {lastname}";
    }

    public IEnumerable<string> GetNameVariation()
    {
        return new[]
        {
            $"{FirstName} {LastName}",
            $"{FirstName}.{LastName}",
            $"{FirstName[0]}.{LastName}",
            $"{FirstName[0]}{LastName}"
        };
    }
}
