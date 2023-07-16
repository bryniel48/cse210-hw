using System;
using System.Collections.Generic;

namespace Develop05{

class Program
{
    static void Main(string[] args)
    {
        int q = 0;
        int totalPoints = 0;
        List<NewGoal> allGoals = new List<NewGoal>();
        
        while(q == 0){

            Console.WriteLine("Total Points: " + totalPoints);
            Console.WriteLine("Welcome to the Mindfulness Exercises");
            Console.WriteLine("Choose one of the folling options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();
            if (choice == "1"){
                NewGoal h = new NewGoal();
                h.createNewGoal();
                allGoals.Add(h);
            }
            
            else if (choice == "2"){
                foreach (NewGoal newGoal in allGoals){
                    Console.WriteLine(newGoal.getGoal());
                }
            }

            else if (choice == "3"){
                SaveGoals s = new SaveGoals();
                s.saveGoals(allGoals);
            }

            else if (choice == "4"){
                LoadGoals l = new LoadGoals();
                List<NewGoal> g = l.loadGoals();
                foreach(NewGoal n in g){
                    allGoals.Add(n);
                }
            }

            else if (choice == "5"){
                int i = 0;
                string _choice = "";
                int choice2 = 0;
                Console.WriteLine("Which goal was completed?");
                foreach(NewGoal listGoal in allGoals){
                    i ++;
                    Console.WriteLine(i + ". " + listGoal.getTitle());
                }
                _choice = Console.ReadLine();
                choice2 = Int32.Parse(_choice);
                choice2 --;
                int j = 0;
                foreach(NewGoal mostGoals in allGoals){
                    if(choice2 == j){
                        int newPoints = mostGoals.runRecordEvent();
                        totalPoints += newPoints;
                        break;
                    }
                    else{
                        j++;
                    }
                }
            }
            else if (choice == "6"){
                q = 1;
                Console.WriteLine("Thank you for participating. Have a great day");
            }

            else{
                Console.WriteLine("Invalid Selection. Please try again.");
            }
        }
    }
}
}