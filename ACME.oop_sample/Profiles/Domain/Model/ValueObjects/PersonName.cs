namespace ACME.oop_sample.Profiles.Domain.Model.ValueObjects;

public struct PersonName
{
    public string? FirstName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
    }
    
    public string? LastName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
    }
    
    public PersonName(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);
    
    public PersonName() : this(string.Empty, string.Empty) { }
    
    public string FullName => $"{FirstName} {LastName}".Trim();
    
    public bool IsAnyNameEmpty => string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName);
}