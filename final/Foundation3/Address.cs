public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string postalCode;

    public Address(string streetAddress, string city, string state, string postalCode)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.postalCode = postalCode;
    }

    public override string ToString()
    {
        return $"{streetAddress}, {city}, {state} {postalCode}";
    }
}
