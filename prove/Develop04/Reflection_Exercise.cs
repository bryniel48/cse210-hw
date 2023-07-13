using System;
using System.Collections.Generic;

namespace Develop04{

    public class Reflection_Exercise:Exercise{
        private List<string> prompts = new List<string>();
        public List<string> promptSetUp(){

            prompts.Add("Think of a time when you stood up for someone else.");
            prompts.Add("Think of a time when you did something really difficult.");
            prompts.Add("Think of a time when you helped someone in need.");
            prompts.Add("Think of a time when you did something truly selfless.");

            return prompts;
        }
        private List<string> questions = new List<string>();
        public List<string> questionSetUp(){

            questions.Add("Why was this experience meaningful to you?");
            questions.Add("Have you ever done anything like this before?");
            questions.Add("How did you get started?");
            questions.Add("How did you feel when it was complete?");    
            questions.Add("What made this time different than other times when you were not as successful?");
            questions.Add("What is your favorite thing about this experience?");
            questions.Add("What could you learn from this experience that applies to other situations?");
            questions.Add("What did you learn about yourself through this experience?");
            questions.Add("How can you keep this experience in mind in the future?");  

            return questions;
        }

        public int overallDelay = 60;
        public int questionDelay = 10;
        public void runReflectionExercise(){
            int runTime = 0;
            displayStartingPrompt("Reflection", overallDelay);
            doTheDelay(2);
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
            doTheDelay(2);
            Console.WriteLine(returnRandomPrompt(promptSetUp()));
            doTheDelay(5);
            while (runTime < overallDelay){
                Console.WriteLine(returnRandomPrompt(questionSetUp()));
                runHashAnimation(questionDelay);
                runTime += questionDelay;
            }
            displayFinalPrompt();
        }
    }
}