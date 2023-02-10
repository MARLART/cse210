using System;

class DealersLoan : Compounder
{
    private double _setupFee, _monthlyFee;

    public DealersLoan(double rate, double setup, double monthly ) : base (rate)
    {
        _setupFee = setup;
        _monthlyFee = monthly;
    }

    public override double FinalBalance()
    {
        // the answer to life the universe and everything
        return 42;
    }


}