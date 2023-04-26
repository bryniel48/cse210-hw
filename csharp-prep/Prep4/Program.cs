using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        Console.WriteLine("Enter a list of numbers. Enter 0 to finish");
        int newNumberInt = 0;
        
        do{
            Console.WriteLine("Please enter a number:");
            String newNumberString = Console.ReadLine();
            newNumberInt = Convert.ToInt32(newNumberString);
            numbersList.Add(newNumberInt);
            }while(newNumberInt != 0 );
        //Console.WriteLine(numbersList);
        int totalAmount = 0;
        int highestNumber = 0;
        foreach (int num in numbersList){
            totalAmount += num;
            int look = num - highestNumber;
            if (look > 0){
                highestNumber = num;
                }
            }
        int totalCount = numbersList.Count - 1;
        double average = (double)totalAmount / totalCount;
        
        Console.WriteLine($"The sum is {totalAmount}");
        Console.WriteLine($"The average was {average}");
        Console.WriteLine($"The highest number is {highestNumber}");
    }
}