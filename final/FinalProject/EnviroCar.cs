using System;

class EnviroCar : Vehicle
{

    private double _cleanCarDiscount, _purchasePrice, _price, _discount, _tradein, _futurePurchasePrice;
    public EnviroCar(double price,  double discount, double tradein, double disc) : base( price, discount, tradein)
    {
        _cleanCarDiscount = disc;
        _price = price;
        _discount = discount;
        _tradein = tradein;
    }

    public override double GetCarCost(double deposit)
    {
        _purchasePrice = _price - _discount - _tradein -_cleanCarDiscount - deposit;
        
        return _purchasePrice;
    }

    public override double GetFutureCarCost(double deposit)
    {
        //assumed tradein will be half by the time the car has been saved for

        _futurePurchasePrice = _price - (_tradein/2) - deposit - _cleanCarDiscount;
     
        return _futurePurchasePrice;
    }


}