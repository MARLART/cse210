using System;

class Calculations
{
    private double _yearlyFuel, _yearlyTotal, _loanPayment, _monthlyRate, _loanAmount;

    public Calculations()
    {
        
    }

    public double CalcRepayments(double rate, double cost, double months, double deposit)
    {
        _monthlyRate = rate/12;
        _loanAmount = cost - deposit;
        //remove deposit amount
        _loanPayment = (_monthlyRate*_loanAmount)/(1-Math.Pow((1+_monthlyRate), (-months)));
        
        return _loanPayment;
    }

    public double YearlyFuel(double weeklyFuel )
    {
        _yearlyFuel = weeklyFuel * 52;

        return _yearlyFuel;
    }

    public double YearlyTotal(double service, double insurance, double weeklyFuel)
    {
        
        _yearlyTotal = YearlyFuel(weeklyFuel) + service + insurance;

        return _yearlyTotal;
    }

    public double CalcTimeSave()
    {
        return 42;
    }

    public void DisplayCarCompare()
    {

    }

    public void DisplayFinanceCompare()
    {
        
    }


}