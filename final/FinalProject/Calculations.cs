using System;

class Calculations
{
    private double _yearlyFuel, _yearlyTotal;

    


    public Calculations()
    {
        
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

    public double CalcRepayments()
    {
        return 42;
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