using System;
using System.Collections.Generic;

namespace Foundations1{
    public class Comments{
        
        private string name;
        private string text;
        private string date;
        public void storeName(string _name){
            name = _name;
        }
        public void storeText(string _text){
            text = _text;
        }
        public void storeDate(string _date){
            date = _date;
        }
        public string getName(){
            return name;
        }
        public string getText(){
            return text;
        }
        public string getDate(){
            return date;
        }

    }

}