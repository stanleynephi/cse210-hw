using System;

// creating a public class for fraction
public class Fraction{
    private int _top;
    private int _buttom;

//constructor with no parameter
    public Fraction(){
        _top = 1;
        _buttom =1;
    }

// constructor with one parameter
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _buttom = 1;
    }

// constructor that has mutiple parameters
    public Fraction(int up, int down){
        _top = up;
        _buttom = down;
    }

    public string GetFractionString(){
        string result = $"{_top}/{_buttom}";
        return result;
    }

    public double GetFractionDouble(){
        double result = (double)_top / (double)_buttom;
        return result;
    }

}