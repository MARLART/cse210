using System;

class BankLoan : Compounder
{
    private double _setupFee, _monthlyFee;

    public BankLoan(double rate, double setup, double monthly ) : base (rate)
    {
        _setupFee = setup;
        _monthlyFee = monthly;
    }

    public override double FinalBalance()
    {
        return 42;
    }


}