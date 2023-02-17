using System;

class Save : Compounder
{

    private double _payment, _futurePurchasePrice, _timeToSave, _repairs, _outOfPocket, _totalPayments, _totalInterest, _totalRepairs;
    public string _sRepairs, _sPayments, _sTotalPaymants, _sTotalInterest, _sOutofPocket;

    Calculations saveCalc = new Calculations();

    public Save(double rate, double payment, double deposit, double futureCarCost, double repairs) : base(rate, deposit)
    {
        _payment = payment;
        _futurePurchasePrice = futureCarCost;
        _repairs = repairs;
       
    }

    public override void  DisplayTotalCost()
    {
        _timeToSave = saveCalc.CalcTimeSave(_deposit, _futurePurchasePrice, _interestRate,  _payment);

        _totalRepairs = (_repairs/12)*_timeToSave;
        _totalPayments = _payment * _timeToSave;
        _totalInterest =_futurePurchasePrice - _totalPayments;
        _outOfPocket =_deposit + _totalPayments + _repairs;

        _sPayments = String.Format("{0:0}", _payment);
        _sTotalPaymants = String.Format("{0:0}", _totalPayments);
        _sRepairs = String.Format("{0:0}", _totalRepairs);
        _sTotalInterest = String.Format("{0:0}", _totalInterest);
        _sOutofPocket = String.Format("{0:0}", _outOfPocket);

        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Save First");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(string.Format("Extra car exp:  {0} ", _sRepairs));
        Console.WriteLine(string.Format("Monthly amount: {0} ", _sPayments));
        Console.WriteLine(string.Format("Time(Months):   {0}", _timeToSave)); 
        Console.WriteLine(string.Format("Interest:       {0}", _sTotalInterest));
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(string.Format("Out-Of Pocket:  {0}", _sOutofPocket ));
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("");
    }

    

}