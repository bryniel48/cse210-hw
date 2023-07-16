using System;
using System.Collections.Generic;

namespace FinalProjectCode{

    public class LoadGoals{
        public List<NewEvent> loadGoals(){
            List<NewEvent> loadedGoals = new List<NewEvent>();
            string filename = "Gym.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines){
                NewEvent the = new NewEvent();
                string[] parts = line.Split(",");

                the.storeDate(parts[0]);
                int i = Int32.Parse(parts[1]);
                the.storeWeight(i);
                i = Int32.Parse(parts[2]);
                the.storeLaps(i);

                
                loadedGoals.Add(the);
            }
            return loadedGoals;
        }
    }
}