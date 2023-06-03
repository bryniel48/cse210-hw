using System;
using System.Collections.Generic;

namespace Develop03{
    public class Words{
        public Scripture theScripture = new Scripture();
        public List<string> origialVerse = new List<string>();
        public List<string> halfList = new List<string>();
        public List<List<string>> fullList = new List<List<string>>();
        public Random rnd = new Random();
        public int howManyWordsTaken = 3;
        public int numberOfWord(){
            List<string> originalVerse = theScripture.givenScripture();
            int numberOfWords = originalVerse.Count;
            return numberOfWords;
        }
        public List<string> takeAway(List<string> words){
            
            int listLength = 25;
            Random rnd = new Random();
            int num = rnd.Next(0,listLength);
            int s = 0;
            bool loopBreaker = false;
            while (loopBreaker == false){
                if (words[num].Contains("_")){
                    num = rnd.Next(0, listLength);
                    s++;
                    if (s == words.Count()){
                        loopBreaker = true;
                    }
                }
                if (!words[num].Contains("_")){
                    loopBreaker = true;
                }
            }
            string word = words[num];
            int wordLength = word.Count();
            string underscore = "";
            for (int i = 0; i <wordLength; i++){
                underscore += "_";
            }
            words.Insert(num, underscore);
            words.RemoveAt(num+1);
            List<string> _scripture = new List<string>();
            foreach (string input in words){
                _scripture.Add(input + " ");
            }
            return _scripture;
        }
    }
}
