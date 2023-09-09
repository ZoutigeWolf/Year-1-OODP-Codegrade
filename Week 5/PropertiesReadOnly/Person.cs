class Person
{
    private string _firstName;
    private string _lastname;

    public string FullName
    {
        get => $"{_firstName} {_lastname}";
    }

    public Person(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastname = lastName;
    }
}