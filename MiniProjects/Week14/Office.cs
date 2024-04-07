class Office
{
    public string OfficeLocation { get; set; }
    public string Currency { get; set; }

    public Office(string officeLocation, string currency)
    {
        OfficeLocation = officeLocation;
        Currency = currency;
    }
}
