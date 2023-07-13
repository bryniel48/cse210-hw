using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Develop04{

    public class Listening_Exercise:Exercise{

        private List<string> prompts = new List<string>();
        public List<string> promptSetUp(){

            prompts.Add("Who are people that you appreciate?");
            prompts.Add("What are personal strengths of yours?");
            prompts.Add("Who are people that you have helped this week?");
            prompts.Add("When have you felt the Holy Ghost this month?");
            prompts.Add("Who are some of your personal heroes?");

            return prompts;
        }
        
        public void runListeningExercise(){
            int numOfTimes = 0;
            string newEntry;
            displayStartingPrompt("Listening", 10);
            Console.WriteLine(returnRandomPrompt(promptSetUp()));
            Console.WriteLine("Think about that");
            runCountDownAnimation(10);

            Console.WriteLine("Being listing as many as you can");
            var startTime2 = DateTime.UtcNow;
            while(DateTime.UtcNow - startTime2 < TimeSpan.FromSeconds(10))
            {
                newEntry = Console.ReadLine();
                numOfTimes ++;
            }
            

            Console.WriteLine("A total of " + numOfTimes + " entries were entered!");
            displayFinalPrompt();
        }
    }
}