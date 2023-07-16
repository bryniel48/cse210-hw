using System;
using System.Collections.Generic;

namespace Develop05{

    public class TempLoad{
        private string typeOfGoal;
        private string name;
        private string description;
        private int pointsWhenCompleted;
        private int timesToComplete;
        private int pointsCheckComplete;
        private int checkTimesCompleted;
        public void storeTypeOfGoal(string _typeOf){
            typeOfGoal = _typeOf;
        }
        public string getTypeOfGoal(){
            return typeOfGoal;
        }
        public void storeTitle(string _name){
            name = _name;
        }
        public string getTitle(){
            return name;
        }
        public void storeDescription(string _description){
            description = _description;
        }
        public string getDescription(){
            return description;
        }
        public void storePointsComplete(int _points){
            pointsWhenCompleted = _points;
        }
        public int getPointsComplete(){
            return pointsWhenCompleted;
        }
        public void storeTimesToComplete(int _timesToComplete){
            timesToComplete = _timesToComplete;
        }
        public int getTimesToComplete(){
            return timesToComplete;
        }
        public void storePointsChecklistComplete(int _checkComplete){
            pointsCheckComplete = _checkComplete;
        }
        public int getPointChecklistComplete(){
            return pointsCheckComplete;
        }
        public void storeCheckTimesCompleted(int _checkTimesCompleted){
            checkTimesCompleted = _checkTimesCompleted;
        }
        public int getCheckTimesCompleted(){
            return checkTimesCompleted;
        }
        
    }
}