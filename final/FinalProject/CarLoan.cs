using System;

class CarLoan : Compounder
{
    private double _setupFee, _termMonths, _payments, _totalPaid, _costCar, _interestRate;
    Calculations loanCalc = new Calculations();

    public CarLoan(double rate, double setup, double term, double carCost ) : base (rate)
    {
        _setupFee = setup;
        _termMonths = term;
        _costCar = carCost;
        _interestRate = rate;

    }

    public override double TotalCost()
    {
        _payments = loanCalc.CalcRepayments(_interestRate, _costCar, _termMonths);

        _totalPaid = _payments * _termMonths;

        Console.WriteLine(string.Format("Payments: {0}, Total: {1}", _payments, _totalPaid));

        return _totalPaid;
    }


}