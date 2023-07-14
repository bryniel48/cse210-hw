using System;
using System.Collections.Generic;

namespace Foundations1{

    public class Video{

        private string title;
        private string author;
        private int length;
        private List<Comments> addedComments = new List<Comments>();

        public void storeTitle(string _title){
            title = _title;
        }
        public void storeAuthor(string _author){
            author = _author;
        }
        public void storeLength(int _length){
            length = _length;
        }
        public string getTitle(){
            return title;
        }
        public string getAuthor(){
            return author;
        }
        public int getLength(){
            return length;
        }
        public void printComments(){
            for (int i = 0; i < 3; i++){
                Console.WriteLine(addedComments[i].getName());
                Console.WriteLine(addedComments[i].getDate());
                Console.WriteLine(addedComments[i].getText());
            }
        }
        public void storeComments(Comments allInfo){
            addedComments.Add(allInfo);
        }

    }

}