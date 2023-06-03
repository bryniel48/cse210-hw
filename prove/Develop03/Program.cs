using System;
using System.Collections.Generic;

namespace Develop03{
class Program
{
    static void Main(string[] args)
    {
        List<string> fullList = new List<string>();
        Scripture newScripture = new Scripture();
        Reference theReference = new Reference();
        Words takeOff = new Words();
        
        Console.WriteLine(theReference.referenceVerse);
        List<string> theOneAndOnly = newScripture.givenScripture();
        
        fullList = takeOff.takeAway(theOneAndOnly);
        int i = 0;
        while (i < 7){
            Console.Clear(); //Place this code
            string shownVerse = "";
            for (int j = 0; j < 26; j++){
                shownVerse += fullList[i][j];
            }
            Console.WriteLine("Enter 1 to proceed");
            Console.WriteLine("Enter 0 to go back");
            string option = Console.ReadLine();
            int choice = Int32.Parse(option);
            if (choice == 0){
                if (i != 0){
                    i--;
                }
            }
            else if (choice == 1){
                i++;
            }
        }
        Console.WriteLine(fullList[6][1]);
        //Console.WriteLine(fullList[24]);
        //Console.WriteLine(takeOff.numberOfWord());
        //Console.WriteLine(newScripture.givenScripture());
    }
}
}