using System;

class Program
{
    static void Main(string[] args)
    {
     
     
        Console.WriteLine("Which is your grade percentage? ");
        string percent = Console.ReadLine();
        int percentage = int.Parse(percent);
        string letter ="";

        if (percentage >= 90)
        {
            letter= "A";
            }

        else if (percentage >= 80)
        {   letter= "B";}
    
        else if (percentage >= 70)
        {   letter= "C";}

        else if (percentage >= 60)
        {   letter= "D";}

        else
        {   letter="F";}

        Console.Write($"Your grade is: {letter}. ");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }




    }
}