using System;

public abstract class Compounder
{

    private double _interestRate;
    public Compounder(double rate)
    {
        _interestRate = rate;
    }

    public double GetInterestRate()
    {
        return _interestRate;
    }

    public abstract double TotalCost();




}