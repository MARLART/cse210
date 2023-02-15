using System;

class CarLoan : Compounder
{
    private double _setupFee, _termMonths, _payments, _totalPaid, _costCar, _interestRate, _totalInterest, _outOfPocket;
    private string _sTotalPaid, _sPayments, _sTotalInterest;
    Calculations loanCalc = new Calculations();

    public CarLoan(double rate, double setup, double term, double carCost, double deposit ) : base (rate, deposit)
    {
        _setupFee = setup;
        _termMonths = term;
        _costCar = carCost;
        _interestRate = rate;

    }

    public override void DisplayTotalCost()
    {
        _payments = loanCalc.CalcRepayments(_interestRate, _costCar, _termMonths, _deposit);
        _totalPaid = (_payments * _termMonths);
        _totalInterest = _totalPaid - _costCar;
        _outOfPocket = _totalPaid + _deposit;

        _sPayments = String.Format("{0:0}", _payments);
        _sTotalPaid = String.Format("{0:0}", _outOfPocket);
        _sTotalInterest = String.Format("{0:0}", _totalInterest);

        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Loan Now");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(string.Format("Monthly amount: {0} ", _sPayments));
        Console.WriteLine(string.Format("Time(Months):   {0}", _termMonths));
        Console.WriteLine(string.Format("Interest:      ({0})", _sTotalInterest));
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(string.Format("Out-Of Pocket:  {0}", _sTotalPaid ));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("");
    }


}