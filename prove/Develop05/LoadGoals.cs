using System;
using System.Collections.Generic;

namespace Develop05{

    public class LoadGoals{
        public List<NewGoal> loadGoals(){
            List<NewGoal> loadedGoals = new List<NewGoal>();
            string filename = "Goals.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines){
                NewGoal the = new NewGoal();
                string[] parts = line.Split(",");

                the.storeTitle(parts[0]);
                the.storeDescription(parts[1]);
                the.storeTypeOfGoal(parts[2]);
                int i = Int32.Parse(parts[3]);
                the.storePointsComplete(i);
                i = Int32.Parse(parts[4]);
                the.storeTimesToComplete(i);
                i = Int32.Parse(parts[5]);
                the.storePointsChecklistComplete(i);
                i = Int32.Parse(parts[6]);
                the.storeCheckTimesCompleted(i);

                loadedGoals.Add(the);
            }
            return loadedGoals;
        }
    }
}