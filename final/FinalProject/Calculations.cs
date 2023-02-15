using System;

class Calculations
{
    private double _yearlyFuel, _yearlyTotal, _loanPayment, _monthlyRate, _loanAmount, _totalInterest, _timeToSave, _saveGoal, _interest, _totalPayments, _outOfPocket, _repairs;
    

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

    public double CalcTimeSave(double deposit, double futureCarCost, double saveRate, double monthlyPayment)
    {
        _totalInterest = 0;
        _timeToSave = 0;
        _saveGoal = deposit;
        _monthlyRate = saveRate/12;

        while (_saveGoal < futureCarCost)
        {
            _interest = _monthlyRate * _saveGoal;
            _totalInterest += _interest;
            _saveGoal += (_interest + monthlyPayment);
            _timeToSave += 1;
            _totalPayments += monthlyPayment;
        }
        
        return _timeToSave;
    }

    public void DisplayCarCompare()
    {

    }

    public void DisplayFinanceCompare()
    {
        
    }


}