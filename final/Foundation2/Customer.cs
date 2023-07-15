using System;
using System.Collections.Generic;

namespace Foundation2{
    public class Customer:Address{
        private string name;
        private string shippingAddress;
        private bool USA;
        public void storeName(string _name){
            name = _name;
        }
        public string getName(){
            return name;
        }
        public void storeshippingAddress(){
            shippingAddress = createShippingAddress();
        }
        public string getShippingAddress(){
            storeshippingAddress();
            return shippingAddress;
        }
        public bool USAFinder(){
            string country = getCountry();
            if (country == "USA" || country == "United State of America"){
                USA = true;
            }
            else{
                USA = false;
            }
            return USA;
        }
    }
}