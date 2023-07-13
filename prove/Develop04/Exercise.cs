using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Develop04{

    public class Exercise{
        public void displayStartingPrompt(string prompt, int delayTime){
            Console.WriteLine();
            Console.WriteLine("Welcome to the " + prompt + " exercise");
            Console.WriteLine("This activity will delay each time for " + delayTime + " seconds");
        }  
        public void displayFinalPrompt(){
            Console.WriteLine("Thank you for doing this exercise. Try another one");
            Console.WriteLine();
        }
        public void doTheDelay(int delayTime){
            var startTime = DateTime.UtcNow;
            while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(delayTime));
        }
        public void runCountDownAnimation(int delayTime){
            int counter = 0;
            int displayCounter = delayTime;
            while(counter < delayTime){
                Console.Write(displayCounter);
                Thread.Sleep(1000);
                displayCounter --;
                counter ++;
                Console.Write("\b\b\b ");
            }
            Console.WriteLine();
        }

        public void runHashAnimation(int delayTime){
            int counter = 0;
            while(counter < delayTime){
                
                switch(counter % 4){
                    case 0: Console.Write("-"); break;
                    case 1: Console.Write("\\"); break;
                    case 2: Console.Write("|"); break;
                    case 3: Console.Write("/"); break;
                }
                Thread.Sleep(1000);
                counter ++;
                Console.Write("\b\b\b");
            }
            Console.WriteLine();
        }
        public string returnRandomPrompt(List<string>prompts){
            Random rnd = new Random();
            int selection = rnd.Next(0, prompts.Count());
            string prompt = prompts[selection];
            return prompt;
        }
    }
}