using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IinterfacesAndAbstractClasses
{
    internal static class InputController
    {

        internal static T AcceptInput<T>(string userPromptMessage)
        {

            bool inputValid = false; // initialize default state

            do
            {
                Console.Write($"{userPromptMessage} : ");

                string userInput = Console.ReadLine();

                // Using this to help me get around empty userInput
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-9.0
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    userPromptMessage = "You may not enter an empty string, try again";
                    continue;
                }

                Console.WriteLine($"userInput Empty? ");

                // I could also declare this T parsedInput within the function call itself to make the variable accessible
                // however this is a little easier to read and follow, I think. The IDE harsses me to inline it, but I still
                // feel like this is a little more readable.
                T parsedInput;
                inputValid = ParseUserInput(userInput, out parsedInput);

                Console.WriteLine($"inputValid : {inputValid}");
                Console.WriteLine($"parsedInput : {parsedInput}");

                if (!inputValid)
                {
                    userPromptMessage = "Input invalid, please try again";
                } else
                {
                    return parsedInput;
                }


            } while (!inputValid);

            // I gues the compiler dislikes that it interprets this as not all code paths returning a value,
            // despite the loop trapping you in perpetuaty unless you do enter a valid input, so I read somewhere that 
            // throwing an exception works, which I guess make sense since it sort of indicates failing gracefully.
            throw new InvalidOperationException("Unreachable code reached in AcceptInput<T>");

        }

        // Learned about a cool way of running type conversions using Convert.ChangeType(), lets see if I can get this working
        // Should be a cool experiment I can carry foward in a useful way for future input validation methods
        // https://learn.microsoft.com/en-us/dotnet/api/system.convert.changetype?view=net-9.0
        internal static bool ParseUserInput<T>(string userInput, out T? parsedInput)
        {


            // OKay so good to know the compiler will ext the program if I don't leverage a try-catch to 
            // handle the exception thrown by trying to parse an incorrect data type.
            try
            {
                // Should return the parsed value of type T parsedInput, or if failure to parse, null
                parsedInput = (T)Convert.ChangeType(userInput, typeof(T));
                return true;
               
            } catch
            {
                parsedInput = default!;
                return false;
            }

        }

    }
}