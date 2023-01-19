using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Let's determine what is your grade. What is your grade? ");
        string UserGradeInput = Console.ReadLine();
        
        string letter = "None";

        int UserGrade = int.Parse(UserGradeInput);

         if (UserGrade >= 90)
         {
            letter = "A";
         }
         else if (UserGrade >= 80)
         {
            letter = "B";
         }
         else if (UserGrade >= 70)
         {
            letter = "C";
         }
         else if (UserGrade >= 60)
         {
            letter = "D";
         }
         else
         {
            letter = "F";
         }
         if (UserGrade >= 70) {
            Console.WriteLine("The minimun grade to pass is 70.........CONGRATULATIONS keep it up!");
         }
         else if (UserGrade < 70) 
         {
            Console.WriteLine("The minimun grade to pass is 70.........You need to put more effot, C'mon you can do it!!");
         }         
        Console.WriteLine($"Your grade is {letter}.");
         
         
    }
}