using System;
using System.Collections.Generic;

namespace Develop03{
class Program
{
    static void Main(string[] args)
    {
        Scripture John3_16 = new Scripture();
        John3_16.storeVerseReference("John 3:16");
        John3_16.storeVerse("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Words firstTry = new Words();
        List<string> totalProcess = firstTry.setUpTakeAway(John3_16);
        int i = 0;
        while(i < totalProcess.Count()){
            Console.Clear();
            Console.WriteLine(totalProcess[i]);
            Console.WriteLine("Here is the scripture. What would you like to do next?");
            Console.WriteLine("1. Proceed to take away more");
            Console.WriteLine("2. Bring back the last words");
            Console.WriteLine("3. Quit");
            string choice = Console.ReadLine();
            if (choice == "1"){
                i++;
            }
            else if(choice == "2"){
                i--;
                if (i == -1){
                    i++;
                }
            }
            else if(choice == "3"){
                break;
            }
            else{
                Console.WriteLine("Invalid selection");
            }
        }
    }
}
}