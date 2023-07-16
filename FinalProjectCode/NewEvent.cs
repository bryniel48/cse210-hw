using System;
using System.Collections.Generic;

namespace FinalProjectCode{
    public class NewEvent{
        private string date;
        private int weight;
        private int laps;
        public void storeDate(string _date){
            date = _date;
        }
        public void storeWeight(int _weight){
            weight = _weight;
        }
        public void storeLaps(int _laps){
            laps = _laps;
        }
        public string getDate(){
            return date;
        }
        public int getWeight(){
            return weight;
        }
        public int getLaps(){
            return laps;
        }
        public void createNewEvent(){
            Console.WriteLine("What is the date for this event?");
            date = Console.WriteLine();
            Console.WriteLine("What is my weight?");
            string _w = Console.ReadLine();
            weight = _w;
            Console.WriteLine("How many laps completed in 15 minutes?");
            string _l = Console.ReadLine();
            laps = _l;
        }
    }
}
