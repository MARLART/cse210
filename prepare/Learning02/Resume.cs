// A code template for the category of things known as Job. The
    // responsibility of Resume is to hold information about different jobs and the person's name details.
    public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs = new List<Job>();

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Resume()
        {
        }
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            {
                job.Display();
            }

        }
    }