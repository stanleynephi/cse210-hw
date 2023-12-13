public class Address{
    // private variables for them
    private String _street;
    private string _city;
    private string _country;

    public Address(){
        SetStreet(_street);
        SetCity(_city);
        SetCountry(_country);
    }

        public string getStreet(){
        return "Country: " + this._country;
    }

    public void SetStreet(string street){
        _street = street;
    }

    public string GetAddress(){
        return "Street: " + this._street + ", City: " + this._city + ", Country: " + this._country;
    }

    public string getCountry(){
        return this._country;
    }

    public void SetCity(string city){
        _city = city;
    }

     public void SetCountry(string country){
        _country = country;
    }

    
}