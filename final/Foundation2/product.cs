public class Product{

    // create a private variable for 
    // product name
    private String _name;

    // product id
    private int _id;

    //product price
    private double _price;

    // product quantity
    private int _quantity;


    public Product(){
        SetName(_name);
        SetQuantity(_quantity);
        SetPrice(_price);
    }
      public string GetName(){
        return _name;
    }


    //a get method for the price
    public double GetPrice(){
        return _price;
    }

     public void SetName(string Name){
        _name = Name;
    }

    // a set method for the price
    public void SetPrice(double price){
        _price = price;
    }


      public double GetQuantity(){
        return _quantity;
    }

    // a set method for the price
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }


    public double TotalPrice(){
        return GetPrice() * GetQuantity();
    }
}