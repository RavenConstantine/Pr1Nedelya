using System;

public class Journal
{
    private string lastName;
    private string firstName;
    private string patronymic;
    public Journal()
    {
    }
    public Journal( string LastName, string FirstName, string Patronymic)
    {
        lastName = LastName;
        firstName = FirstName;
        patronymic = Patronymic;
    }
    public string ShowData()
    {
        string str = lastName + " " + firstName + " " + patronymic;
        return str;
    }
    public string TakeLName()
    {
        return lastName;
    }
}
