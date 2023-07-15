using System;
using System.Collections.Generic;

namespace Foundation3{
    public class Receptions:Event{
        private string eventType = "Receptions";
        private List<string> RSVP = new List<string>();

        public void storeRSVP(string _RSVP){
            RSVP.Add(_RSVP);
        }
        public List<string> getRSVPList(){
            return RSVP;
        }
         public string getFullDetails(){
            string fullDetails = ("This is a " + eventType + " event\n");
            fullDetails += getStandardDetails();
            fullDetails += ("\nThese are the people on the RSVP list:");
            getRSVPList();
            foreach(string person in RSVP){
                fullDetails += ("\n" + person);
            }
            return fullDetails;
        }   
        public string getShortDescription(){
            string hello = eventType + "\n";
            hello += getEndOfShortDescription();
            return hello;
        }
    }
}