using System;

class LargeCar : Vehicle
{

    private double _uteTax = 3000;
     private double _price, _discount, _tradein, _purchasePrice,  _futurePurchasePrice;

    public LargeCar(double price, double discount, double tradein) : base (price, discount, tradein)
    {
        _price = price;
        _discount = discount;
        _tradein = tradein;
    }

    public override double GetCarCost(double deposit)
    {
        _purchasePrice = _price - _discount - _tradein - deposit+ _uteTax;
        return _purchasePrice;
    }

    public override double GetFutureCarCost(double deposit)
    {
        //assumed tradein will be half by the time the car has been saved for

            _futurePurchasePrice = _price - (_tradein/2) - deposit + _uteTax;
            
        return _futurePurchasePrice;
    }



}