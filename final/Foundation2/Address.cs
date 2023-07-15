using System;
using System.Collections.Generic;

namespace Foundation2{
    public class Address{
        private string shippingAddress;
        private string streetAddress;
        private string city;
        private string state;
        private string country;
        public void storeStreetAddress(string _streetAddress){
            streetAddress = _streetAddress;
        }
        public void storeCity(string _city){
            city = _city;
        }
        public void storeState(string _state){
            state = _state;
        }
        public void storeCountry(string _country){
            country = _country;
        }
        public string getStreetAddress(){
            return streetAddress;
        }
        public string getCity(){
            return city;
        }
        public string getState(){
            return state;
        }
        public string getCountry(){
            return country;
        }
        public string createShippingAddress(){
            shippingAddress = (streetAddress + "\n" + city + "," + state + "\n" + country);
            return shippingAddress;
        }
    }
}