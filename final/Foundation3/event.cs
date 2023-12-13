using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection;


// class for address
public class Address{
    private string _street;
    private string _city;
    private string _country;

    public Address(string street, string city, string country){
        this._street = street;
        this._city = city;
        this._country = country;
    }

    public string GetAddress1(){
        return $"{_street},{_city},{_country}";
    }


// create a class for the RSVP
public class RSVP{
    private string _name;
    private int _number;

    public RSVP(string name,int _number){
        this._name = name;
        this._number = _number;
    }

    public string Getdetails(){
        return $"Name: {_name}, Number:{_number}";
    }
}

// create 
}
public class Event{

    private string _title;

    private string _discription;

    private DateTime _date;

    private string _address;

    public Event(string title, string address,string discription,DateTime date){
        _title = title;
        _discription = discription;
        _date = date;
        _address =address;

    }

    public string Gettitle(){
        return _title;
    }

    public string GetDisctiption(){
        return _discription;
    }

       public string Getdetails(){
        return $"{_title},{_address},{_discription}, {_date}";
    }

    public string GetDate(){
        return _date.ToShortDateString();
    }
}


public class Lectures : Event {
    private string LecturerName;
    private int ClassCapacity;

    public Lectures (string title, string address,string discription,string name, int capacity, DateTime date) : base(title,address,discription,date){
        LecturerName = name;
        ClassCapacity = capacity;
    }

    public string GetLecturersName(){
        return LecturerName;
    }
}


// create a class for the reception

public class Reception : Event {
    private string RSVPname = "Nuley Nephi Stanle";
    private int RSVPnumber = 0201172848;

    public Reception(string title,string address, string discription, DateTime date, string rsvp, int number) : base (title,address,discription,date){
        RSVPname = rsvp;
        RSVPnumber =  number;
    }

    public string GetRSVP(){
        return $"{RSVPname}, {RSVPnumber}";
    }
}

