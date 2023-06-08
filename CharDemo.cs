using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsorted_Integer_Arrays
{
    internal class CharDemo
    {
        public static void PrintingChar()
        {

            #region String to Char Array

            string Str = "arunkumar";
            Console.WriteLine(Str);

            //string to char array
            char[] c1 = Str.ToCharArray();

            //printing a char array
            Console.WriteLine(string.Join("", c1));

            //modifying a char array
            c1[0] = char.ToUpper(c1[0]);
            Console.WriteLine(string.Join("", c1));

            #endregion

            char[] mysample = new char[] { '1', '2', 'A', 'a', '?', '+' };

            #region IsDigit

            //IsDigit
            if (char.IsDigit(mysample[1]))
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Not a Digit");
            }

            if (char.IsDigit(mysample[2]))
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Not a Digit");
            }

            #endregion

            #region IsLetter

            if (char.IsLetter(mysample[2]))
            {
                Console.WriteLine("Letter");
            }
            else
            {
                Console.WriteLine("Not a Letter");
            }

            if (char.IsLetter(mysample[1]))
            {
                Console.WriteLine("Letter");
            }
            else
            {
                Console.WriteLine("Not a Letter");
            }

            #endregion

            #region IsLetterOrDigit

            if (char.IsLetterOrDigit(mysample[1]))
            {
                Console.WriteLine("Letter or Digit");
            }
            else
            {
                Console.WriteLine("Not a Letter or Digit");
            }

            if (char.IsLetterOrDigit(mysample[4]))
            {
                Console.WriteLine("Letter or Digit");
            }
            else
            {
                Console.WriteLine("Not a Letter or Digit");
            }

            #endregion

            #region IsLower

            if (char.IsLower(mysample[3]))
            {
                Console.WriteLine("Lower Case");
            }
            else
            {
                Console.WriteLine("Not Lower Case");
            }

            if (char.IsLower(mysample[2]))
            {
                Console.WriteLine("Lower Case");
            }
            else
            {
                Console.WriteLine("Not Lower Case");
            }

            #endregion

            #region IsUpper

            //IsUpper
            if (char.IsUpper(mysample[2]))
            {
                Console.WriteLine("Upper Case");
            }
            else
            {
                Console.WriteLine("Not Upper Case");
            }

            if (char.IsUpper(mysample[3]))
            {
                Console.WriteLine("Upper Case");
            }
            else
            {
                Console.WriteLine("Not Upper Case");
            }

            if (char.IsUpper(mysample[1]))
            {
                Console.WriteLine("Upper Case");
            }
            else
            {
                Console.WriteLine("Not Upper Case");
            }

            #endregion

            #region IsPuncutation

            if (char.IsPunctuation(mysample[4]))
            {
                Console.WriteLine("Punctuation");
            }
            else
            {
                Console.WriteLine("Not a Punctuation");
            }

            #endregion

            #region IsSymbol

            if (char.IsSymbol(mysample[5]))
            {
                Console.WriteLine("Symbol");
            }
            else
            {
                Console.WriteLine("Not a Symbol");
            }

            #endregion

            #region Printing char array to Uppercase

            string sample = "aruNKumar";
            char[] c2 = sample.ToCharArray();

            //printing a char array
            Console.WriteLine(string.Join("", c2));

            //Converting char array to Uppercase
            for (int i = 0; i < c2.Length; i++)
            {
                if (c2[i] >= 97 && c2[i] <= 122)
                {
                    c2[i] = (char)(c2[i] - 32);
                }
            }
            //printing a char array after conversion to upper case
            Console.WriteLine(string.Join("", c2));

            #endregion

            #region chars and equivalent integers 

            char[] mychars = new char[] { '0', '1' };

            Console.WriteLine(string.Join(", ", mychars));

            //printing the integer equivalent or ascii value
            Console.WriteLine((int)mychars[0]);

            Console.WriteLine((int)mychars[1]);

            #endregion

            #region char array to numbers/positions of alphabet

            char[] myinput = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };

            //printing a char array 
            Console.WriteLine(string.Join(" ", myinput));

            for (int i = 0; i < myinput.Length; i++)
            {
                Console.Write(myinput[i] - 96 + " ");
            }

            #endregion

            #region Sample char to location/position/index in alphabet

            string newstring = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(newstring);
            char[] cs = newstring.ToCharArray();
            for (int i = 0; i < cs.Length; i++)
            {
                Console.Write(cs[i] - 96 + " ");
            }

            #endregion

            #region Sample int to corresponding char - Atcoder recent contest question

            int[] ma = new int[] { 1, 2, 3, 4, 13, 26, 24, 5 };

            for (int i = 0; i < ma.Length; i++)
            {
                Console.Write((char)(ma[i] + 96) + " ");
            }

            #endregion

        }
    }
}
