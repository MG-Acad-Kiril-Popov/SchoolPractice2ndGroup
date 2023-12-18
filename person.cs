 class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }

    public Person(string firstName, string lastName, DateTime birthDate, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Address = address;
    }

    public int CalculatePersonAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        if (DateTime.Now < BirthDate.AddYears(age)) age--;
        return age;
    }

    public virtual void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Age: {CalculatePersonAge()} years old");
        Console.WriteLine($"Address: {Address}");
    }
}
