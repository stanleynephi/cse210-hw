// class of order
using System.Diagnostics.CodeAnalysis;

public class Order{
    //product list
    List<Product>_product;
    //customer
    Customer _customer;

    public Order(Customer customer,Product prod){
        this._customer = customer;
        _product = new List<Product>();
    }

    //method to add items to the product list
    public void AddItemToOrder(Product p) {
        _product.Add(p);
    }

    // method to return a string for packing
    public string Label(){
        return _customer.FullDetail();
    }

    //caculate for the total price
    public double TotalPrice(){
        double sum = 0.0;
        foreach(Product prod in _product){
            sum += prod.TotalPrice();
        }

        // conditionals
        if(_customer.Country() == "USA"){
            sum += 5;
        }
        else{
            sum += 35;
        }

        return sum;
    }
}