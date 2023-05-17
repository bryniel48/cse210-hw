using System.Collections.Generic;
using System;

namespace Develop02
{
    public class Prompt
    {
        Random rnd = new Random();
        public List<string> prompts;
        
        public Prompt()
        {
            prompts = new List<string>();
            prompts.Add("What was a highlight of your day?");
            prompts.Add("How have you seen God's hand in your day?");
            prompts.Add("Did you see an animal today?");
            prompts.Add("Did you meet anyone new?");
            prompts.Add("On a scale of 1-10, how was your day? Explain");
        }
        public string getRandomPrompt()
        {
            int numberOf = prompts.Count;
            int index = rnd.Next(0,numberOf);
            return prompts[index];
        }
        
    }
}