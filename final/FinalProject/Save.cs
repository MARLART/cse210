using System;

class Save : Compounder
{

    private double _payment, _openBal;
    public Save(double rate, double payment, double openBal) : base(rate)
    {
        _payment = payment;
        _openBal = openBal;
    }

    public override double FinalBalance()
    {
        return 42;
    }


}