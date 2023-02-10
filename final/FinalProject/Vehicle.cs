using System;

public abstract class Vehicle
{

    private double _price, _discount, _tradein, _purchasePrice, _diesel;
    private bool _isDiesel;
    public Vehicle(double price, bool diesel, double discount, double tradein)
    {
        _price = price;
        _isDiesel = diesel;
        _discount = discount;
        _tradein = tradein;
    }

    public Vehicle()
    {
        //current vehicle only
    }

    public virtual double CalcPrice()
    {
        if (_isDiesel == true)
        {
            _diesel = 1000;
        }
        else
        {
            _diesel = 0;
        }

        _purchasePrice = _price - _discount - _tradein + _diesel;
        return _purchasePrice;
    }





}