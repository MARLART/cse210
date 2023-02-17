using System;

class Menu 
{   
    private double _rateSave = 0.0195;
    private double _rateloan = 0.129;
    private double _feeloan = 249;
    private double _termMonths = 60;
    private double _cleanCarDisc = 3700;
     private double _uteTax = 3000;
    private double _govDiscFees = 0;
    private double _carCost, _carDiscount, _deposit, _saveAmount, _repairs, _tradein, _futureCarCost, _price, _cLitres, _eLitres, _cService, _eService, _cInsure, _eInsure, _km, _cFuelTotal, _eFuelTotal, _cYearlyTotal, _eYearlyTotal, _repayments, _lostInterest, _yearlyRepayments, _loanInterest;
    private string _choice, _finance, _sLostInterest, _sCFuelTotal, _sEFuelTotal, _sYearlyRepayments, _sLoanInterest, _sCYearlyTotal, _sEYearlyTotal;

    public Menu() 
    {
        
    }

    public void MenuBuySave()
    {
        Console.Clear();
        Console.WriteLine("Please enter the following details:");
        Console.WriteLine("");

        //get loan / save details
        SaveQuestions();
        LoanQuestions();

        //get details on current car and create current car object
        Console.WriteLine("what EXTRA repair or other costs do you expect if you keep your current car That you WON'T have with a new car? (Yearly Amount): ");
        _repairs = double.Parse(Console.ReadLine());

        //get details on new car and create object
        Console.WriteLine("");
        Console.WriteLine("What type of car are you considering? ");
        Console.WriteLine("1.Electric / Hybrid");
        Console.WriteLine("2. Small / Medium");
        Console.WriteLine("3. Large");
        string _carType = Console.ReadLine();

        CarQuestions();

        if (_carType == "1")
        {
            Vehicle enviro = new EnviroCar(_price,_carDiscount,_tradein,_cleanCarDisc);
            _carCost = enviro.GetCarCost(_deposit);
            _futureCarCost = enviro.GetFutureCarCost(_deposit);
            _govDiscFees = _cleanCarDisc;

;
        }
        else if (_carType == "2")
        {
            Vehicle small = new SmallMedCar(_price,_carDiscount,_tradein);
            _carCost = small.GetCarCost(_deposit);
            _futureCarCost = small.GetFutureCarCost(_deposit);
            
       }

        else if (_carType == "3")
        {

            Vehicle large = new LargeCar(_price,_carDiscount,_tradein);
            _carCost = large.GetCarCost(_deposit);
            _futureCarCost = large.GetFutureCarCost(_deposit);
            _govDiscFees = 0- _uteTax;

        }

        Compounder save1 = new Save(_rateSave, _saveAmount, _deposit, _futureCarCost, _repairs);
        Compounder loan1 = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit); 

        DisplayCarCost();
        loan1.DisplayTotalCost();
        save1.DisplayTotalCost();
        
    }

    public void MenuElecPetrol()
    {
        Console.WriteLine("");
        
        CarQuestions();
        Vehicle ecar = new EnviroCar(_price, _carDiscount, _tradein, _cleanCarDisc);
        

        Console.WriteLine("How will you finance your purchase?  ");
        Console.WriteLine("1. Savings for the full amount");
        Console.WriteLine("2. Loan for the full amount");
        Console.WriteLine("2. Deposit from savings and Loan for the rest");
        

        _finance = Console.ReadLine();

        if (_finance == "1")
        {
            SaveQuestions();
            Compounder save2 = new Save(_rateSave, _saveAmount, 0, _futureCarCost, _repairs);
            _carCost = ecar.GetCarCost(0);

        }
        else if (_finance == "2")
        {
            LoanQuestions();
            Compounder loan2 = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, 0);
            _carCost = ecar.GetCarCost(0);
        }
        else
        {
            SaveQuestions();
            Compounder save2 = new Save(_rateSave, _saveAmount, _deposit, _futureCarCost, _repairs);
            LoanQuestions();
            Compounder loan2 = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit);
            _carCost = ecar.GetCarCost(_deposit);
        }



        Console.WriteLine("How many kilometers do you normally drive in a year?");
        _km = double.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Current Car Questions");
        Console.WriteLine("How many litres per 100km does your current car use? ");
        _cLitres = double.Parse(Console.ReadLine());
        Console.WriteLine("What are your yearly servicing and repair costs?");
        _cService = double.Parse(Console.ReadLine());
        Console.Write("What are your yearly insurance costs? ");
        _cInsure = double.Parse(Console.ReadLine());

        Calculations cCalc = new Calculations();
        _cFuelTotal  =  cCalc.YearlyFuel(_km, _cLitres);

        if (_finance == "1")
        {
            _lostInterest = cCalc.CalcYearInterest(_carCost, _rateSave);
        }
        else if (_finance == "3")
        {
            _lostInterest = cCalc.CalcYearInterest(_deposit, _rateSave);
        }
        _cYearlyTotal =  cCalc.YearlyTotal(_cService, _cInsure, _km, _cLitres) + _lostInterest;

        Console.WriteLine("");
        Console.WriteLine("Evironmental Car Questions");
        Console.WriteLine("How many litres per 100km will the new car use? ");
        _eLitres = double.Parse(Console.ReadLine());
        Console.WriteLine("What will the yearly servicing and repair costs be?");
        _eService = double.Parse(Console.ReadLine());
        Console.Write("What will your yearly insurance costs be? ");
        _eInsure = double.Parse(Console.ReadLine());

        Calculations eCalc = new Calculations();
        _repayments = eCalc.CalcRepayments(_rateloan, _carCost, _termMonths);
        _yearlyRepayments = _repayments * 12;
        _loanInterest = _yearlyRepayments + _lostInterest;
        _eFuelTotal  =  eCalc.YearlyFuel(_km, _eLitres);

        //calculate total cost for e car based on financing option
        if (_finance == "1")
        {
            _eYearlyTotal =  eCalc.YearlyTotal(_eService, _eInsure, _km, _eLitres) + _lostInterest;
        }
        else if (_finance == "2")
        {
            _eYearlyTotal =  eCalc.YearlyTotal(_eService, _eInsure, _km, _eLitres) + _yearlyRepayments;
        }
        else
        {
            _eYearlyTotal =  eCalc.YearlyTotal(_eService, _eInsure, _km, _eLitres) + _loanInterest;
        }
        

        NumbersToString();
        DisplayPetrolElec();
    }

    public void MenuCompareAll()
    {
        Compounder save = new Save(_rateSave, _saveAmount, _deposit, _futureCarCost, _repairs);
        Compounder loan = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit);

        //Vehicle current = new CurrentCar(1);
        Vehicle enviro = new EnviroCar(_price,_carDiscount,_tradein,_cleanCarDisc);
        Vehicle small = new SmallMedCar(_price,_carDiscount,_tradein);
        Vehicle large = new LargeCar(_price,_carDiscount,_tradein);
    }

    public void DisplayCarCost()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Lets compare borrowing cost to saving cost.");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("               Loan Amount    Saving Goal");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(string.Format("Car Price:     {0}          {0}", _price));
        Console.WriteLine(string.Format("Less:"));
        Console.WriteLine(string.Format("Deposit:       {0}          {0}", _deposit));
        Console.WriteLine(string.Format("Sale discount: {0}           0", _carDiscount));
        Console.WriteLine(string.Format("Tradein:       {0}          {1}", _tradein, (_tradein/2)));
        Console.WriteLine(string.Format("Gov disc/fees: {0}          {0}", _govDiscFees));
        Console.WriteLine(string.Format("               ------------------"));
        Console.WriteLine(string.Format("Amount needed: {0}          {1}", _carCost, _futureCarCost));
        Console.WriteLine("");
        
    }

    public void SaveQuestions()
    {
        Console.WriteLine("How much do you have saved already? ");
        _deposit = double.Parse(Console.ReadLine());
        Console.WriteLine("How much do intend to save every month? ");
        _saveAmount = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the interest rate on your savings account?(numbers only)");
        _rateSave = (double.Parse(Console.ReadLine()))/100;
    }

    public void LoanQuestions()
    {
        Console.WriteLine("Do you want to use standard interest rates and fees or enter your own? ");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Enter my own interest rates and fees");
        _choice = Console.ReadLine();
        Console.WriteLine("");

        if (_choice == "2")
        {
            Console.WriteLine("What is the interest rate on the loan ");
            _rateloan = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("what is the Loan setup fee? ");
            _feeloan = double.Parse(Console.ReadLine());
            Console.WriteLine("How many months is the Loan for? ");
            _termMonths = double.Parse(Console.ReadLine());
        }

    }

    public void CarQuestions()
    {
        Console.WriteLine("What is the standard price of this car?");
        _price = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the discount available?");
        _carDiscount = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the tradein value you will recieve?");
        _tradein = double.Parse(Console.ReadLine());
    }

    public void DisplayPetrolElec()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Lets compare the costs for 1 year between your current car and a  new electric/hybrid car.");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("               Current      New");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(string.Format("Fuel Cost:     {0}         {1}", _sCFuelTotal, _sEFuelTotal));
        Console.WriteLine(string.Format("Servicing:     {0}          {1}", _cService, _eService));
        Console.WriteLine(string.Format("Insurance:     {0}          {1}", _cInsure, _eInsure));

        if ( _finance == "1")
        {
            Console.WriteLine(string.Format("Lost interest:  0           {0}", _sLostInterest));
        }
        else if (_finance == "2")
        {
            Console.WriteLine(string.Format("Loan repayments: 0           {0}", _sYearlyRepayments));
        }
        else
        {
            Console.WriteLine(string.Format("Loan & Interest: 0           {0}", _sLoanInterest));
        }

        Console.WriteLine(string.Format("               ------------------"));
        Console.WriteLine(string.Format("Year Cost:     {0}           {1}", _sCYearlyTotal , _sEYearlyTotal));
        Console.WriteLine("");
    }

    private void NumbersToString()
    {
        _sCFuelTotal = String.Format("{0:0}", _cFuelTotal);
        _sEFuelTotal = String.Format("{0:0}", _eFuelTotal);
        _sLoanInterest = String.Format("{0:0}", _loanInterest);
        _sLostInterest = String.Format("{0:0}", _lostInterest);
        _sYearlyRepayments = String.Format("{0:0}", _yearlyRepayments);
        _sCYearlyTotal = String.Format("{0:0}", _cYearlyTotal);
        _sEYearlyTotal = String.Format("{0:0}", _eYearlyTotal);
    }



}