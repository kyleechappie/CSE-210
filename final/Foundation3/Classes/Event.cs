//Properties: Title, Description, Date, Time, Address.
//Methods:
    //GenerateStandardDetailsMessage(): Returns a string with standard details of the event.
    //GenerateFullDetailsMessage(): Returns a string with full details of the event.
    //GenerateShortDescriptionMessage(): Returns a string with a short description of the event type, title, and date.

using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandard()
    {
        string standard = "Title: " + _title + "\n";
        standard += "Description: " + _description + "\n";
        standard += _date + " | " + _time + "\n";

        string address = _address.GenerateCompleteAddress();
        standard += address;
        return standard;
    }

    public string GenerateShort()
    {
        string shortM = "Name: " + _title + "\n";

        shortM += _date + "\n";
        return shortM;
    }
}