using System;
using System.Collections.Generic;

namespace Foundation4{
    public class NewGoal:TempLoad{

        
        public void createNewGoal(){
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string _typeOfGoal = Console.ReadLine();
            storeTypeOfGoal(_typeOfGoal);
            Console.WriteLine("What is the name of the goal?");
            string title = Console.ReadLine();
            storeTitle(title);
            Console.WriteLine("What is a short description of the goal?");
            string description = Console.ReadLine();
            storeDescription(description);
            Console.WriteLine("What is the amount of points associated?");
            string place = Console.ReadLine();
            int points = Int32.Parse(place);
            storePointsComplete(points);
            if (_typeOfGoal == "1"){

            }
            else if(_typeOfGoal == "2"){

            }
            else if(_typeOfGoal == "3"){
                Console.WriteLine("How many times to complelte?");
                string place2 = Console.ReadLine();
                int toComplelte = Int32.Parse(place2);
                storeTimesToComplete(toComplelte);
                Console.WriteLine("How many points is it worth once completed?");
                string place3 = Console.ReadLine();
                int totalCheckList = Int32.Parse(place3);
                storePointsChecklistComplete(totalCheckList);
            }
            else{
                Console.WriteLine("Invalid Input");
                createNewGoal();
            }
        }
        public int runRecordEvent(){
            int newPoints = getPointsComplete();
            RecordEvent ev = new RecordEvent();
            if(getTypeOfGoal() == "1"){
                string x = ev.getGoal();
                storeTitle(x);
            }
            else if(getTypeOfGoal() == "2"){

            }
            else if(getTypeOfGoal() == "3"){
                int i = getCheckTimesCompleted();
                i ++;
                storeCheckTimesCompleted(i);
                if(getCheckTimesCompleted() == getTimesToComplete()){
                    string x = ev.getGoal();
                    storeTitle(x);
                    newPoints += getPointChecklistComplete();
                }
            }
            else{
                Console.WriteLine("Something has gone very wrong");
            }
            return newPoints;
        }
        public virtual string getGoal(){
            string sentence = "";
            sentence = (getTitle() + " ( " + getDescription() + " )");
            if (getTypeOfGoal() == "3"){
                sentence += (" -- Currently Complelted " + getCheckTimesCompleted() + "/" + getTimesToComplete());
            }
            return sentence;
        }
    }
}
    

