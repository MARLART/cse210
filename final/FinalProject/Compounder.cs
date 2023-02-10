using System;

public abstract class Compounder
{

    private double _interestRate, _price, _openBal, _payments, _currentBal, _term, interestPayments;
    public Compounder(double rate)
    {
        _interestRate = rate;
    }

    public double GetInterestRate()
    {
        return _interestRate;
    }

    public double GetPrice()
    {
        return _price;
    }

    public double GetTerm()
    {
        return _term;
    }

    public abstract double FinalBalance();




}