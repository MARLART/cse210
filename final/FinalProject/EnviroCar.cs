using System;

class EnviroCar : Vehicle
{

    private double _cleanCarDiscount, _purchasePrice, _price, _discount, _tradein;
    public EnviroCar(double price, bool diesel, double discount, double tradein, double disc) : base( price, diesel, discount, tradein)
    {
        _cleanCarDiscount = disc;
        _price = price;
        _discount = discount;
        _tradein = tradein;
    }

    public override double GetCarCost()
    {
        _purchasePrice = _price - _discount - _tradein -_cleanCarDiscount;
        
        return _purchasePrice;
    }


}