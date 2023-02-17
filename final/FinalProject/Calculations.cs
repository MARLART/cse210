using System;

class Calculations
{
    private double _yearlyFuel, _yearlyTotal, _loanPayment, _monthlyRate, _loanAmount, _totalInterest, _timeToSave, _saveGoal, _interest, _totalPayments, _yearInterest, _principle;
    private double _pricePerLitre = 2.40;
    

    public Calculations()
    {
        
    }

    public double CalcRepayments(double rate, double cost, double months)
    {
        _monthlyRate = rate/12;

        _loanAmount = cost;
       
        _loanPayment = (_monthlyRate*_loanAmount)/(1-Math.Pow((1+_monthlyRate), (-months)));
                        
        return _loanPayment;
    }

    public double YearlyFuel(double kilometers , double litres)
    {
        _yearlyFuel = (kilometers/100) * litres * _pricePerLitre;

        return _yearlyFuel;
    }

    public double YearlyTotal(double service, double insurance, double kilometers, double litres )
    {
        
        
        _yearlyTotal = YearlyFuel(kilometers, litres) + service + insurance;

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

    public double CalcYearInterest(double amount, double rate)
    {
        _monthlyRate = rate/12;
        _principle = amount;

        for (int months=0; months<12; months++)
        {
            _interest = _principle * _monthlyRate;
            _principle += _interest;
            _yearInterest += _interest;
        }
        return _yearInterest;
    }



}