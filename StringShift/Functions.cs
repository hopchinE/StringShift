using System.Text.RegularExpressions;

namespace StringShift;

public class Functions
{
    /// <summary>
    /// this function will take in a string and integer then shift the characters to the right
    /// by the number of times of the provided integer
    /// </summary>
    /// <param name="input">The string to be shifted</param>
    /// <param name="check">The number of times to shift the characters of the string</param>
    /// <returns></returns>
    public static string shift(string input, int check)
    {
        //remove spaces from string to comply with results from second example
        input = Regex.Replace(input, @"\s+", "");
        //create new char array to handle output of shifted input string
        char[] output = new char[input.Length];
        //get the shift position of the string by performing a modulo operation on the shift value input to ensure it doesn't exceed the bounds of the array
        int shift = check % input.Length;

        //loop through the input string characters
        foreach(char c in input.ToCharArray())
        {
            //assign the character to its shifted position
            output[shift] = c;
            //increment the shift value
            shift++;
            //check if the shift variable has reached outside the bounds of the array
            if(shift >= input.Length)
            {
                //once this condition is met, set value to zero to begin writing characters at the beginning of the string
                shift = 0;
            }
        }

        return new string(output);
    }

    /// <summary>
    /// function to validate user input and convert an acceptable numeric input to an integer 
    /// </summary>
    /// <param name="input">the string input value</param>
    /// <param name="input2">the numeric input of how many spaces the input should be shifted</param>
    /// <param name="shift">an output variable for converting the numeric string input to an integer</param>
    /// <returns></returns>
    public static bool validate(string? input, string? input2, out int shift)
    {
        bool valid = true;

        if(string.IsNullOrEmpty(input))
        {
            valid = false;
            Console.WriteLine("The first input cannot be empty");
        }
        else if(!input.All(x => char.IsLetter(x)))
        {
            valid = false;
            Console.WriteLine("The input string must only contain alphabet characters");
        }
        if(!int.TryParse(input2, out shift))
        {
            valid = false;
            Console.WriteLine("The second input must be a valid integer");
        }

        return valid;
    }

}