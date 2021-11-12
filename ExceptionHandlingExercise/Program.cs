using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            var arr = new char[] {'1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numbers = new List<int> { };
            var str = "";

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            
                // Now create a try catch
                
                
                    // Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list

          
                for (var i = 0; i< arr.Length;i++)
                {  
                    try
                        {
                        str = arr[i].ToString();
                        int intVariable = int.Parse(str);
                        numbers.Add(intVariable);
                    }      
                    catch
                    {
                        Console.WriteLine($"Unable to Parse '{str}'"); //character will be the name of each item in your collection
                    }
                } 
      

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection


            Console.Write("These are the array elements I was able to copy into the integer list: ");
            foreach (var num in numbers)
            {
                Console.Write($"{num}   ");
            }
            Console.WriteLine("");
        }
    }
}
