using System;
using System.Reflection.Metadata.Ecma335;

public class Resume 
    {
        public String _name;
        public List<Job> _jobs = new List<Job>();

    
        
        
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");
            foreach (Job job in _jobs)
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }