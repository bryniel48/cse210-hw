using System;
using System.Collections.Generic;

namespace Foundation3{
    public class Outdoor:Event{
        private string eventType = "Outdoor";
        private string weatherReport;

        public void storeWeatherReport(string _weather){
            weatherReport = _weather;
        }
        public string getWeatherReport(){
            return weatherReport;
        }

         public string getFullDetails(){
            string fullDetails = ("This is a " + eventType + " event\n");
            fullDetails += getStandardDetails();
            getWeatherReport();
            fullDetails += ("\nThe weather report is: " + weatherReport);
            return fullDetails;
         }
        public string getShortDescription(){
            string hello = eventType + "\n";
            hello += getEndOfShortDescription();
            return hello;
        }
    }
}