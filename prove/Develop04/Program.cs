using System;
using System.Collections.Generic;

namespace Develop04{
class Program
{
    static void Main(string[] args)
    {
        Exercise newExercise = new Exercise();
        Listening_Exercise listen = new Listening_Exercise();
        Breathing_Exercise breath = new Breathing_Exercise();
        Reflection_Exercise reflect = new Reflection_Exercise();
        int q = 0;
        
        while(q == 0){
            Console.WriteLine("Welcome to the Mindfulness Exercises");
            Console.WriteLine("Choose one of the folling options:");
            Console.WriteLine("1. Listening Exercise");
            Console.WriteLine("2. Breathing Exercise");
            Console.WriteLine("3. Reflection Exercise");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();
            if (choice == "1"){
                listen.runListeningExercise();
            }
            
            else if (choice == "2"){
                breath.runBreathingExercise();
            }

            else if (choice == "3"){
                reflect.runReflectionExercise();
            }

            else if (choice == "4"){
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