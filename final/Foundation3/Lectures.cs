using System;
using System.Collections.Generic;

namespace Foundation3{
    public class Lectures:Event{
        private string eventType = "Lectures";
        private string speaker;
        private int capacity;
        public void storeSpeaker(string _speaker){
            speaker = _speaker;
        }
        public void storeCapacity(int _capacity){
            capacity = _capacity;
        }
        public string getSpeaker(){
            return speaker;
        }
        public int getCapacity(){
            return capacity;
        }
        public string getFullDetails(){
            string fullDetails = ("This is a " + eventType + " event\n");
            fullDetails += getStandardDetails();
            fullDetails += ("\nThe speaker is " + speaker + "\nWith a capacity of " + capacity);
            return fullDetails;
        }
        public string getShortDescription(){
            string hello = eventType + "\n";
            hello += getEndOfShortDescription();
            return hello;
        }
    }
}