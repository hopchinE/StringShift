using System;

namespace StringShift;

class Program
{
    static void Main(string[] args)
    {
        // //get user inputs
        Console.WriteLine("Please enter the string you would like to have shifted");
        string? input = Console.ReadLine();
        Console.WriteLine("Please enter how far you would like to have the string shifted");
        string? input2 = Console.ReadLine();

        int check = 0;

        //call to validate input
        if(Functions.validate(input, input2, out check))  
        {
            //call to shift string function
            string write = Functions.shift(input, check);
            //print out shifted string
            Console.WriteLine($"The output string shifted by {input2} is {write}");
        }
        Console.WriteLine("Press enter to exit");
        Console.ReadLine();
    }
}
