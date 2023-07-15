using System;
using System.Collections.Generic;

namespace Foundation3{
    public class Event{
        //Lists the title, description, date, time, and address.
        private string title;
        private string description;
        private string date;
        private string time;
        private string address;
        private string standardDetails;
        public string getEndOfShortDescription(){
            string sentence = (title + "\n" + date);
            return sentence;
        }

        public void storeTitle(string _title){
            title = _title;
        }
        public void storeDescription(string _description){
            description = _description;
        }
        public void storeDateAndTime(string _date, string _time){
            date = _date;
            time = _time;
        }
        public void storeAddress(string _address){
            address = _address;
        }
        public string getTitle(){
            return title;
        }
        public string getDescription(){
            return description;
        }
        public string getDateAndTime(){
            string junto = (date + " " + time);
            return junto;
        }
        public string getAddress(){
            return address;
        }
        public void storeStandardDetails(){
            //getAddress(); getDateAndTime(); getDescription(); getTitle();
            standardDetails = ("Title: " + title + "\nDescription: " + description + "\nDate and Time: " + getDateAndTime() + "\nAddress: " + address);
        }
        public string getStandardDetails(){
            storeStandardDetails();
            return standardDetails;
        }
    }
}