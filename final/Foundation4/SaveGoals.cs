using System;
using System.Collections.Generic;
using System.IO;

namespace Foundation4{

    public class SaveGoals{
        public void saveGoals(List<NewGoal> theList){
            string fileName = "Goals.txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(NewGoal indvGoal in theList){
                    outputFile.WriteLine($"{indvGoal.getTitle()},{indvGoal.getDescription()},{indvGoal.getTypeOfGoal},{indvGoal.getPointsComplete()},{indvGoal.getTimesToComplete()},{indvGoal.getPointChecklistComplete()},{indvGoal.getCheckTimesCompleted()}");
                }                                   
            }   
        }
    }
}