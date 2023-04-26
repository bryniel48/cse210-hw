using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static String PromptUserName(){
        Console.WriteLine("Enter your name:");
        String name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Enter your favorite number:");
        String favNumString = Console.ReadLine();
        int favNum = Convert.ToInt32(favNumString);
        return favNum;
    }
    static int SquareNumber(int num){
        int newNum = num * num;
        return newNum;
    }
    static void DisplayInfo(String name, int num){
        Console.WriteLine($"{name}, your favorite number squared is {num}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        String name = PromptUserName();
        int favNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favNumber);

        DisplayInfo(name, squaredNumber);
    }
}