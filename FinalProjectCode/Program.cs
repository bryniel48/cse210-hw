using System;
using System.Collections.Generic;

namespace FinalProjectCode{

class Program
{
    static void Main(string[] args)
    {
        bool q = false;
        List<NewEvent> allEvent = new List<NewEvent>();
        LoadGoals savedGoals = new LoadGoals();
        allEvent = savedGoals.loadGoals();
        while(q == false){

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Log new event");
            Console.WriteLine("2. quit");
            string choice = Console.ReadLine();
            if (choice == "1"){
                NewEvent h = new NewEvent();
                h.createNewEvent();
                allEvent.Add(h);
            }
            
            else if (choice == "2"){
                q = true;
                SaveGoals s = new SaveGoals();
                s.saveGoals(allEvent);
                }

            else{
                Console.WriteLine("Invalid Selection. Please try again.");
            }
        }
    }
}
}