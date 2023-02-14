using System;

class Save : Compounder
{

    private double _payment;
    public Save(double rate, double payment, double deposit) : base(rate, deposit)
    {
        _payment = payment;
       
    }

    public override double TotalCost()
    {
        return 42;
    }


}