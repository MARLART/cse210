using System;

public abstract class Compounder
{

    public double _interestRate, _deposit;
    public Compounder(double rate, double deposit)
    {
        _interestRate = rate;
        _deposit = deposit;
    }

    public double GetInterestRate()
    {
        return _interestRate;
    }

    public abstract void DisplayTotalCost();




}