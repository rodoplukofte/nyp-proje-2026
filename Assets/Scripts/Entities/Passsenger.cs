public class Passenger
{
    public string FullName;
    public string Nationality;
    public bool HasValidDocuments;

    public Passenger(string fullName, string nationality)
    {
        FullName = fullName;
        Nationality = nationality;
        HasValidDocuments = true;
    }
}