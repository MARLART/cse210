// A code template for the category of things known as Job. The
    // responsibility of Job is to hold information about different jobs
    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company= "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        // A method that displays the job's details
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
    