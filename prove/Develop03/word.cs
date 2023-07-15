using System;
using System.Collections.Generic;

namespace Develop03{
    public class Words{
        private int wordCount;
        private string verse;
        
        public void storeWordCount(int _wordCount){
            wordCount = _wordCount;
        }
        public int getWordCount(){
            return wordCount;
        }
        public string toAddVerse(string[] list){
            string sentence = "";
            foreach(string word in list){
                sentence += (word + " ");
            }
            return sentence;
        }
        public List<string> setUpTakeAway(Scripture original){
            List<int> takenWords = new List<int>();
            int wordsTakenPer = 3;
            verse = original.getVerse();
            string[] splitVerse = verse.Split(" ");
            storeWordCount(original.getWordCount());
            List<string> setUp = new List< string>();
            setUp.Add(toAddVerse(splitVerse));
            int timesPerTake = (wordCount / wordsTakenPer) - 1;
            //Console.WriteLine(wordCount);
            //Console.WriteLine(wordsTakenPer);
            //Console.WriteLine(timesPerTake);
            bool evenAmount;
            int leftOver = 0;
            if ((wordCount % wordsTakenPer) == 0){
                evenAmount = true;
            }
            else{
                evenAmount = false;
                leftOver = wordCount % wordsTakenPer;
            }
            Random rnd = new Random();
            for(int i = 0; i < (wordCount - leftOver); i+=3){
                int j = 0;
                while (j < wordsTakenPer){
                    //Console.WriteLine(wordCount);
                    int num = rnd.Next(0, wordCount);
                    if (takenWords.Contains(num) == false){
                        takenWords.Add(num);
                        j++;
                    }
                }
            }
            //foreach(int x in takenWords){
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(takenWords.Count());
            //Console.WriteLine(timesPerTake);
            int amountForThis = wordCount - (wordCount % wordsTakenPer);
            //Console.WriteLine(amountForThis);
            for(int z = 0; z < amountForThis; z += wordsTakenPer){
                string[] tempString = splitVerse;
                tempString[takenWords[z]] = "___";
                tempString[takenWords[z+1]] = "___";
                tempString[takenWords[z+2]] = "___";
                //foreach(string s in tempString){
                //    Console.Write(s);
                //}
                Console.WriteLine();
                setUp.Add(toAddVerse(tempString));
            }
            
            
            if (evenAmount == false){
                int q = 0;
                List<int> leftOverWords = new List<int>();
                while(q < leftOver){
                    int num = rnd.Next(0, wordCount);
                    if (takenWords.Contains(num) == false){
                        leftOverWords.Add(num);
                        q++;
                    }
                }
                string[] tempString = splitVerse;
                for(int p = 0; p < leftOver; p++){
                    tempString[leftOverWords[p]] = "___";
                }
                setUp.Add(toAddVerse(tempString));
                }
            return setUp;
        }
    }
}
