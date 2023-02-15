using System;

public abstract class Vehicle
{

    private double _price, _discount, _tradein, _purchasePrice, _futurePurchasePrice;

    public Vehicle(double price, double discount, double tradein)
    {
        _price = price;
        _discount = discount;
        _tradein = tradein;
    }

    public virtual double GetCarCost(double deposit)
    {

            _purchasePrice = _price - _discount - _tradein - deposit;
       
      
        return _purchasePrice;
    }

    public virtual double GetFutureCarCost(double deposit)
    {
        //assumed tradein will be half by the time the car has been saved for

            _futurePurchasePrice = _price - (_tradein/2) - deposit;

        return _futurePurchasePrice;
    }

    

}