using System;
using System.Collections.Generic;

namespace Develop03{

    public class Scripture{
        private string verse;
        private string verseName;
        public void storeVerseReference(string _name){
            verseName = _name;
        }
        public string getVerseReference(){
            return verseName;
        }
        public void storeVerse(string _verse){
            verse = _verse;
        }
        public string getVerse(){
            return verse;
        }
        public int getWordCount(){
            int count = 0;
            string[] words = verse.Split(' ');
            foreach(string word in words){
                count++;
            }
            return count;
        }
    }
}