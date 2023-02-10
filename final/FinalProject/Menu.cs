using System;

class Menu 
{

    public Menu() 
    {
        
    }

    public void MenuBuySave()
    {
        Compounder save = new Save(1, 1, 1);
        Compounder bank = new BankLoan(1,1,1);
        Compounder deal = new DealersLoan(1,1,1);

        Vehicle current = new CurrentCar();
        
        Console.WriteLine("");
        Console.WriteLine("1.Electric / Hybrid");
        Console.WriteLine("2. Small / Medium");
        Console.WriteLine("3. Large");
        Console.Write("What type of car are you considering? ");

        string _carType = Console.ReadLine();

        if (_carType == "1")
        {
            Vehicle enviro = new EnviroCar();
        }
        else if (_carType == "2")
        {
            Vehicle small = new SmallMedCar();
        }

        else if (_carType == "3")
        {
            Vehicle large = new LargeCar();
        }
    }

    public void MenuElecPetrol()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Savings");
        Console.WriteLine("2. Bank Loan");
        Console.WriteLine("3. Dealer Loan");
        Console.Write("How will you finance your purchase?  ");

        string _finance = Console.ReadLine();

        if (_finance == "1")
        {
            Compounder save = new Save(1, 1, 1);
        }
        else if (_finance == "2")
        {
            Compounder bank = new BankLoan(1,1,1);
        }

        else if (_finance == "3")
        {
            Compounder deal = new DealersLoan(1,1,1);
        }

        Console.WriteLine("");
        Console.WriteLine("1. Current Car");
        Console.WriteLine("2. New small / medium fossil fuel car");
        Console.WriteLine("3. New large fossil fuel car");
        Console.Write("What are you comparing the new electric / hybrid car to?  ");

        string _carType = Console.ReadLine();

        if (_carType == "1")
        {
            Vehicle current = new CurrentCar();
        }
        else if (_carType == "2")
        {
            Vehicle small = new SmallMedCar();
        }

        else if (_carType == "3")
        {
            Vehicle large = new LargeCar();
        }
    }

    public void MenuCompareAll()
    {
        Compounder save = new Save(1, 1, 1);
        Compounder bank = new BankLoan(1,1,1);
        Compounder deal = new DealersLoan(1,1,1);

        Vehicle current = new CurrentCar();
        Vehicle enviro = new EnviroCar();
        Vehicle small = new SmallMedCar();
        Vehicle large = new LargeCar();
    }


}