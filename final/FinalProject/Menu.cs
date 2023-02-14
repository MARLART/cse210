using System;

class Menu 
{   
    private double _rateSave = 0.0195;
    private double _rateloan = 0.129;
    private double _feeloan = 249;
    private double _termMonths = 60;
    private double _cleanCarDisc = 5000;
    private double _carCost, _carDiscount, _deposit, _saveAmount, _repairs, _tradein;
    private bool _diesel = false;

    public Menu() 
    {
        
    }

    public void MenuBuySave()
    {
        Console.Clear();
        Console.WriteLine("Please enter the following details:");
        Console.WriteLine("");

        //get details on current car and create current car object
        Console.WriteLine("what extra repair or other costs do you expect if you keep your current car (Yearly Amount): ");
        _repairs = double.Parse(Console.ReadLine());
        Vehicle current = new CurrentCar(_repairs);

        //get details on new car and create object
        Console.WriteLine("");
        Console.WriteLine("What type of car are you considering? ");
        Console.WriteLine("1.Electric / Hybrid");
        Console.WriteLine("2. Small / Medium");
        Console.WriteLine("3. Large");
        string _carType = Console.ReadLine();

        Console.WriteLine("What is the standard price of this car?");
        _carCost = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the discount available?");
        _carDiscount = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the tradein vaue you will recieve?");
        _tradein = double.Parse(Console.ReadLine());

        if (_carType == "1")
        {
            Vehicle enviro = new EnviroCar(_carCost,_diesel,_carDiscount,_tradein,_cleanCarDisc);
            _carCost = enviro.GetCarCost();
            Console.WriteLine(_carCost);
        }
        else if (_carType == "2")
        {
            Console.Write("Does it use diesel fuel? (Y/N): ");
            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                _diesel = true;
            }
            Console.WriteLine();
            Vehicle small = new SmallMedCar(_carCost,_diesel,_carDiscount,_tradein);
            _carCost = small.GetCarCost();
        }

        else if (_carType == "3")
        {
            Console.Write("Does it use diesel fuel? (Y/N): ");
            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                _diesel = true;
            }
            Console.WriteLine();
            Vehicle large = new LargeCar(_carCost,_diesel,_carDiscount,_tradein);
            _carCost = large.GetCarCost();
            Console.WriteLine(_carCost);
        }

        //get loan / save details
        Console.WriteLine("How much do you have saved already? ");
        _deposit = double.Parse(Console.ReadLine());
        Console.WriteLine("How much do intend to save every month? ");
        _saveAmount = double.Parse(Console.ReadLine());


        Console.WriteLine("Do you want to use standard interest rates and fees or enter your own? ");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Enter my own interest rates and fees");
        string _choice = Console.ReadLine();
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

        Compounder save = new Save(_rateSave, _saveAmount, _deposit);
        Compounder loan = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit); 

        Console.WriteLine(loan.TotalCost());

        
    }

    public void MenuElecPetrol()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Savings");
        Console.WriteLine("2. loan Loan");
        Console.Write("How will you finance your purchase?  ");

        string _finance = Console.ReadLine();

        if (_finance == "1")
        {
            Compounder save = new Save(_rateSave, _saveAmount, _deposit);
        }
        else if (_finance == "2")
        {
            Compounder loan = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit);
        }


        Console.WriteLine("");
        Console.WriteLine("1. Current Car");
        Console.WriteLine("2. New small / medium fossil fuel car");
        Console.WriteLine("3. New large fossil fuel car");
        Console.Write("What are you comparing the new electric / hybrid car to?  ");

        string _carType = Console.ReadLine();

        Vehicle enviro = new EnviroCar(_carCost,_diesel,_carDiscount,_tradein,_cleanCarDisc);

        if (_carType == "1")
        {
            Vehicle current = new CurrentCar(1);
        }
        else if (_carType == "2")
        {
            Vehicle small = new SmallMedCar(_carCost,_diesel,_carDiscount,_tradein);
        }

        else if (_carType == "3")
        {
            Vehicle large = new LargeCar(_carCost,_diesel,_carDiscount,_tradein);
        }
    }

    public void MenuCompareAll()
    {
        Compounder save = new Save(_rateSave, _saveAmount, _deposit);
        Compounder loan = new CarLoan(_rateloan,_feeloan,_termMonths, _carCost, _deposit);

        Vehicle current = new CurrentCar(1);
        Vehicle enviro = new EnviroCar(_carCost,_diesel,_carDiscount,_tradein,_cleanCarDisc);
        Vehicle small = new SmallMedCar(_carCost,_diesel,_carDiscount,_tradein);
        Vehicle large = new LargeCar(_carCost,_diesel,_carDiscount,_tradein);
    }



}