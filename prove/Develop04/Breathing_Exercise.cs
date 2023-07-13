using System;
using System.Collections.Generic;

namespace Develop04{

    public class Breathing_Exercise:Exercise{

        public int delayTime = 30;
        public void runBreathingExercise(){
            int runTime = 0;
            int whichOne = 0;
            displayStartingPrompt("Breathing", delayTime);
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.");
            Console.WriteLine("Clear your mind and focus on your breathing.");
            while(runTime < delayTime){
                if(whichOne == 0){
                    Console.WriteLine("Breathe In...");
                    runCountDownAnimation(4);
                }
                else{
                    Console.WriteLine("Breathe Out....");
                    runCountDownAnimation(4);
                }
                whichOne ++;
                whichOne %= 2;
                runTime += 4;
            }
            displayFinalPrompt();
        }
    }
}