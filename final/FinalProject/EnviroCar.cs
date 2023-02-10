using System;

class EnviroCar : Vehicle
{

    private double _cleanCarDiscount;
    public EnviroCar(double price, bool diesel, double discount, double tradein, double disc) : base( price, diesel, discount, tradein)
    {
        _cleanCarDiscount = disc;
    }

    public override double CalcPrice()
    {
        return 42;
    }


}