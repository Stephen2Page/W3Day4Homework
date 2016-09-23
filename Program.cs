using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace W3Day4Homework
{
    class Program
    {
        //You are given a piece of text. Your job is to write a program that sets the case of text characters according to the following rules:

        //  The first letter of the line should be in uppercase.
        //  The next letter should be in lowercase.
        //  The next letter should be in uppercase, and so on.
        //  Any characters, except for the letters, are ignored during determination of letter case.
        //https://www.codeeval.com/open_challenges/156/

        //  Input: To be, or not to be: that is the question.
        //  Output: To Be, Or NoT tO bE: tHaT iS tHe QuEsTiOn.


        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\RollerCoaster.txt");

            while (!reader.EndOfStream)                             //Read thru file
            {
                string line = reader.ReadLine();                    
                StringBuilder processedLine = new StringBuilder();

                bool firstOccurance = true;

                for (int i = 0; i < line.Length; i++)                //read thru characters on line
                {
                    char character = line[i];

                    if (char.IsLetter(line[i]))                     //Check if char is letter then change case
                    {
                        if (firstOccurance == true)                 //first or second occurance of a letter
                        {
                            character = char.ToUpper(line[i]);
                            firstOccurance = false;                  //keeps track of alternating letters
                        }
                        else
                        {
                            character = char.ToLower(line[i]);
                            firstOccurance = true;
                        }
                    }
                    processedLine.Append(character.ToString());
                }
                Console.WriteLine(processedLine);
            }
        }
    }
}
