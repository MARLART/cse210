using System;

class LargeCar : Vehicle
{

    private double _uteTax;
    public LargeCar(double price, bool diesel, double discount, double tradein, double tax) : base (price, diesel, discount, tradein)
    {
        _uteTax = tax;
    }

    public override double CalcPrice()
    {
        return 42;
    }


}