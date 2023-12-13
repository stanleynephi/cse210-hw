using System.Security.Cryptography.X509Certificates;

public class Customer{
    // private varaibles for the names and the address
    private String _name;
    private Address address;

    public Customer(Address _address,string name){
        address = _address;
        _name = name;
    }

    public string GetName(){
        return _name;
    }

    //setname
    public void SetName(string newName) {
        _name = newName;
    }

    //  method to determine wheter country is usa
    public string Country(){
        return address.getCountry();
    }

    public string Country1(){
        if(address.getCountry() == "USA"){
            return "The customer lives in USA.";
        }
        else{
            return "The customer does not live in USA.";
        }
    }

    public string FullDetail(){
        return "Name: " + _name + "\n" + "Street: " + address.GetAddress() + "\n";
    }

}