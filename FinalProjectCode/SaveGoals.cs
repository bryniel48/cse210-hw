using System;
using System.Collections.Generic;
using System.IO;

namespace FinalProjectCode{

    public class SaveGoals{
        public void saveGoals(List<NewEvent> theList){
            string fileName = "Goals.txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(NewEvent indvGoal in theList){
                    outputFile.WriteLine($"{indvGoal.getDate()}, {indvGoal.getWeight()}, {indvGoal.getLaps}");
                }                                   
            }   
        }
    }
}