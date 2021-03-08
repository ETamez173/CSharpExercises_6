using System;


// Working With Strings | C# | Tutorial 6

namespace CSharpExercises_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // concatenation 
            string phrase = "Peanut " + "Butter " + "and " + "Jelly";
            //Console.WriteLine("Giraffe\nAcademy");
            //Console.WriteLine("\"Giraffe\" Academy");
            //Console.WriteLine(phrase);
            //Console.WriteLine(phrase.Length);

            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.ToLower());

            //Console.WriteLine(phrase.Contains("Peanuts"));

            // find out what character is in a certain location
            // indexing means in word Peanut p = 0 index, e = 2, a = 3 etc.

            //Console.WriteLine(phrase.IndexOf("Butter"));

            //Console.WriteLine(phrase.IndexOf("J"));
            // getting a -1 means the character is not within the string
            //Console.WriteLine(phrase.IndexOf("x"));

            Console.WriteLine(phrase.Substring(7));
            Console.WriteLine(phrase.Substring(7, 6));
         

            Console.ReadLine();
        }
    }
}
