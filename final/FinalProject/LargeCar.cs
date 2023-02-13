using System;

class LargeCar : Vehicle
{

    private double _uteTax = 3000;
     private double _price, _discount, _tradein, _purchasePrice, _diesel;
     private bool _isDiesel;

    public LargeCar(double price, bool diesel, double discount, double tradein) : base (price, diesel, discount, tradein)
    {
        _price = price;
        _isDiesel = diesel;
        _discount = discount;
        _tradein = tradein;
    }

    public override double GetCarCost()
    {
        if (_isDiesel == true)
        {
            _diesel = 1000;
        }
        else
        {
            _diesel = 0;
        }

        _purchasePrice = _price - _discount - _tradein + _diesel+ _uteTax;
        return _purchasePrice;
    }


}