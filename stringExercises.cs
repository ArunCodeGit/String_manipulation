using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using Unsorted_Integer_Arrays;
using static System.Net.Mime.MediaTypeNames;

namespace stringExercises 
{ 
    class StringExercises
    {
        public static void Main(string[] args)
        {
            //Console.Write("Provide the parent string: ");
            ////string ParentInput = Console.ReadLine();
            //Console.Write("Please provide the string value: ");
            //string Input = Console.ReadLine();
            ////Console.Write("Please provide the string value 2: ");
            //string Input1 = Console.ReadLine();
            //Console.Write("Provide the value of K: ");
            //int K = Convert.ToInt32(Console.ReadLine());
            //SecondMostRepeated(Input);

            StringDemo.PrintString();
        }


        #region 1. Find the length of a given string
        public static void FindLenOfString(string Input)
        {
            int X = 0;
            foreach(char item in Input)
            {
                Console.WriteLine("Character:{0} =  {1}",X+1, Input[X]);
                X++;
            }
            
        }
        #endregion

        #region 2. Find the frequency (count) of all unique characters in a given string.
        public static void Unique_Count(string Input)
        {
            for (int i = 0; i < Input.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < Input.Length; j++)
                {
                    if (Input[i] == Input[j])
                    {
                        count += 1;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(Input[i]);
                }
            }
        }
        #endregion

        #region 3. Given a string and a character, return the count of occurrence of that character in the given string.
        public static void FindCharInString(string Input)
        {
            char[] InputArray = Input.ToCharArray();
            Console.Write("Provide a character: ");
            char value = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i=0; i<InputArray.Length;i++)
            {
                if (InputArray[i]==value)
                {
                    count++;        
                }                
            }
            if(count>0)
            {
                Console.WriteLine("Given character {0} is occurred {1} times in the {2}.", value, count, Input);
            }
            else
            {
                Console.WriteLine("Given character not found in the string.");
            }
        }
        #endregion

        #region 4. Given a string, write code to count the number of unique characters in the string.
        public static void FindUniqueChar(string Input)
        {
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
            for(int i=0; i<Input.Length;i++)
            {
                if (MyDict.ContainsKey(Input[i]))
                {
                    MyDict[Input[i]] += 1;
                }
                else
                {
                    MyDict.Add(Input[i], 1);
                }
            }
            int Count = 0;

            foreach (var item in MyDict)
            {
                if (item.Value == 1)
                {
                    Count++;
                }
            }
            Console.WriteLine($"Unique character count is: {Count}");
        }
        #endregion

        #region 5. Given a string, print only those characters that appear more than once.
        public static void PrintCharMorethanOnce(string Input, int K)
        {
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
            char[] InputArray = Input.ToCharArray();
            var Value = Input.Split(' ');
            for (int i = 0; i < Input.Length; i++)
            {
                if (MyDict.ContainsKey(Input[i]))
                {
                    MyDict[Input[i]] += 1;
                }
                else
                {
                    MyDict.Add(Input[i], 1);
                }
            }

            foreach (var item in MyDict)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
        #endregion

        #region 6. Given a string, print only those characters that appear more than k times.
        public static void PrintCharMorethanKtimes(string Input, int K)
        {
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
            char[] InputArray = Input.ToCharArray();
            var Value = Input.Split(' ');
            //int count = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                if (MyDict.ContainsKey(Input[i]))
                {
                    MyDict[Input[i]] += 1;
                }
                else
                {
                    MyDict.Add(Input[i], 1);
                }
            }

            foreach (var item in MyDict)
            {
                if (item.Value > K)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
        #endregion

        #region 7. Count the number of digitis, vowels, and consonants in a given string.
        public static void CountOfString(string value)
        {
            char[] chars = value.ToCharArray();
            int VowelCount = 0;
            int ConsCount = 0;
            for(int i=0; i<chars.Length;i++)
            {
                if (chars[i]=='a' || chars[i]=='e' || chars[i]=='i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    VowelCount++;
                }
                else
                {
                    ConsCount++;
                }
            }
            Console.WriteLine("Vowel: {0}, Constant: {1}, Total character: {2}", VowelCount, ConsCount, VowelCount+ConsCount);
        }

        #endregion

        #region 8. Given a string, replace all occurrences of vowels with uppercase equivalent of the same vowel. (anand -> AnAnd).
        public static void VowelUpperCase(string Input)
        {
            string Result = string.Empty;
            for(int i=0; i<Input.Length;i++)
            {
                if (Input[i] == 'a' || Input[i] == 'e' || Input[i] == 'i' || Input[i] == 'o' || Input[i] == 'u')
                {
                    Result += (char)(Input[i] - 32);
                }
                else
                {
                    Result += (char)(Input[i]); 
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 9. Given a string, remove all vowels from the string and print the rest of the characters.
        public static void RemoveVowels(string Input)
        {
            string Result = string.Empty;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == 'a' || Input[i] == 'e' || Input[i] == 'i' || Input[i] == 'o' || Input[i] == 'u')
                {
                    continue;
                }
                else
                {
                    Result += (char)(Input[i]);
                }                
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 10. Given a string, remove all consonants from the string and print the rest of the characters.
        public static void RemoveConsonants(string Input)
        {
            string Result = string.Empty;
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == 'a' || Input[i] == 'e' || Input[i] == 'i' || Input[i] == 'o' || Input[i] == 'u')
                {
                    Result += (char)(Input[i]);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 11. Given a string, write code to find a character that appears only once and replace it with another character.
        public static void FindACharReplace(string Input, char replaceChar)
        {
            char[] chars = Input.ToCharArray();
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
            string Result = string.Empty;
            for(int i=0; i<chars.Length;i++)
            {
                if (MyDict.ContainsKey(Input[i]))
                {
                    MyDict[Input[i]] += 1;
                }
                else
                {
                    MyDict.Add(Input[i], 1);
                }
            }
            foreach (var item in MyDict)
            {
                if (item.Value == 1)
                {
                    Result += replaceChar;
                }
                else
                {
                    Result += item.Key;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 12. Write a code to find characters that appears more than once and replace it with another character at all its occurrences.
        public static void FindMorethanOnceCharReplace(string Input, char replaceChar)
        {
            char[] chars = Input.ToCharArray();
            Dictionary<char, int> MyDict = new Dictionary<char, int>();
            string Result = string.Empty;
            for (int i = 0; i < chars.Length; i++)
            {
                if (MyDict.ContainsKey(Input[i]))
                {
                    MyDict[Input[i]] += 1;
                }
                else
                {
                    MyDict.Add(Input[i], 1);
                }
            }
            foreach (var item in MyDict)
            {
                if (item.Value > 1)
                {
                    Result += replaceChar;
                }
                else
                {
                    Result += item.Key;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 13. Write code to count the number of uppercase, lowercase, numeric and symbol characters in a given string.
        public static void SeparateStringCount(string Input)
        {
            char[] chars = Input.ToCharArray();
            int LowerCaseCount = 0;
            int UpperCaseCount = 0;
            int NumericCount = 0;
            int SymbolCount = 0;
            for(int i=0; i< chars.Length;i++)
            {
                if (chars[i] >=97 && chars[i] <=122)
                {
                    LowerCaseCount++;
                }
                else if (chars[i] >= 65 && chars[i] <= 90)
                {
                    UpperCaseCount++;
                }
                else if (chars[i] >= 48 && chars[i] <= 57)
                {
                    NumericCount++;
                }
                else
                {
                    SymbolCount++;
                }
            }
            Console.WriteLine("Lowercase count: {0}, Uppercase count: {1}, Numeric count: {2}, Symbol Count: {3}", LowerCaseCount, UpperCaseCount, NumericCount, SymbolCount);
        }
        #endregion

        #region 14. Find the frequency (count) of all unique characters in a given string.
        public static void FrequencyUniqueChar(string Input)
        {
            List<char> MyList = new List<char>();
            char[] chars= Input.ToCharArray();
            for(int i=0; i<chars.Length;i++)
            {
                if (!MyList.Contains(chars[i]))
                {
                    MyList.Add(chars[i]);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(MyList.Count);
        }
        #endregion

        #region 15. Write code to check if the given input string contains only numeric characters (0 to 9).
        public static void CheckNumericOnly(string Input)
        {
            char[] chars= Input.ToCharArray();
            bool IsBool = false;
            foreach(char item in chars)
            {
                if (item >= 48 && item <= 57)
                {
                    IsBool = true;
                }
                else
                {
                    IsBool=false;
                    break;
                }
            }
            Console.WriteLine(IsBool);
        }
        #endregion

        #region 16. Write code to remove non-numeric characters from a given input string.
        public static void RemoveNonNumericChars(string Input)
        {
            char[] chars = Input.ToCharArray();
            string Result = string.Empty;
            foreach (char item in chars)
            {
                if (item >= 48 && item <= 57)
                {
                    Result += item;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 17. Write code to remove special symbols (!,@,#,$,%,^,&,*,(,),-,+,=,_)
        public static string RemoveSpecialSymbol(string Input)
        {
            char[] chars = Input.ToCharArray();
            string Result = string.Empty;
            for(int i=0; i<chars.Length;i++)
            {
                if ((chars[i]>=33 && chars[i]<=45) || chars[i]==64 || chars[i]==94 || chars[i]==95)
                {
                    continue;
                }
                else
                {
                    Result += chars[i];
                }
            }
            return Result;
        }
        #endregion

        #region 18. Write code to remove numeric characters from a given string.
        public static string RemoveNumericChars(string Input)
        {
            char[] chars = Input.ToCharArray();
            string Result = string.Empty;
            foreach (char item in chars)
            {
                if (item >= 48 && item <= 57)
                {
                    continue;
                }
                else
                {
                    Result += item;
                }
            }
            return Result;
        }
        #endregion

        #region 19. Write to remove all the spaces, digits and special symbols (!,@,#,$,%,^,&,*,(,),-,+,=,_) from a given string.
        public static void RemoveSpaceSymbols(string Input)
        {
            char[] chars = Input.Trim().ToCharArray();
            string Result = string.Empty;
            foreach(char item in chars)
            {
                if((item>=48 && item <=57) || (item>=33 && item <=45) || (item == 64) || (item>=94 && item <= 95) )  //|| (( chars[item] == 64 || chars[item] == 94 || chars[item] == 95)
                {
                    continue;
                }
                else
                {
                    Result += item;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 20. Write code to check if a given string/pattern is present in another input string.
        public static bool CheckInputExistInParent(string parentInput, string Input)
        {
            string[] parentStr = parentInput.Split();
            bool IsTrue = false;
            foreach(string value in parentStr)
            {
                if(value.Equals(Input))
                {
                    IsTrue = true;
                    break;
                }
                else
                {
                    IsTrue = false;
                }
            }
            return IsTrue;
        }
        #endregion

        #region 21. Write code to return the index of such a string/pattern in the parent string.
        public static int ReturnIndexOfInputInParent(string parentInput, string Input)
        {
            string[] parentStr = parentInput.Split();
            int IndexPos = -1;
            foreach(string value in parentStr)
            {
                if(value.Equals(Input))
                {
                    IndexPos++;
                    break;
                }
                else
                {
                    IndexPos++;
                }
            }
            return IndexPos;
        }
        #endregion

        #region 22. Write code to return the index of such a string/pattern in the parent string, after a given starting serach position 'K'.
        public static int ReturnIndexOfInputInParentPosK(string parentInput, string Input, int K)
        {
            string[] parentStr = parentInput.Split();
            int IndexPos = -1;
            foreach (string value in parentStr)
            {
                if (value.Equals(Input) && K<=IndexPos)
                {
                    IndexPos++;
                    break;
                }
                else
                {
                    IndexPos++;
                }
            }
            return IndexPos;
        }
        #endregion

        #region 23. Write code to create a new string by concatenating the first 2 and the last 2 chars of the given string.  If the length of the given string is less than 2, then return an empty string.
        public static string Concantenation(string Input)
        {
            string Result = string.Empty;
            
            if (Input.Length>2)
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    Result = string.Concat(Input.Substring(0, 2), Input.Substring(Input.Length - 2, 2));
                }
            }
            else
            {
                return Result;
            }
            return Result;
        }
        #endregion

        #region 24. Write code to create a new string by concantenating the first K and the last K chars from a given string.  If the length of the given string is less than K, then return an empty string.
        public static string ConcatKchars(string Input, int K)
        {
            string Result = string.Empty;

            if (Input.Length > K)
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    Result = string.Concat(Input.Substring(0, K), Input.Substring(Input.Length - K, K));
                }
            }
            else
            {
                return Result;
            }
            return Result;
        }
        #endregion

        #region 25. Replace all occurrences of the first char with '$', except for the first occurrence. (e.g.: Input: "anand", Output: "an$nd")
        public static string ReplaceOccur(string Input)
        {
            char[] chars = Input.ToLower().ToCharArray();
            string Result = string.Empty;
            for(int i=0; i<chars.Length;i++)
            {
                if ((chars[i] == chars[0]) && i>0)
                {
                    Result += '$';
                }
                else
                {
                    Result += chars[i];
                }
            }
            return Result;
        }
        #endregion

        #region 26. Write code to create a single string from two given strings, separted by a space and swap the first two characters of each string.  (input: 'abc', 'ijk', Output: 'ijc', 'abk')
        public static void SwapFirstChar(string Input1, string Input2)
        {
            string FirstSetSubStr = Input1.Substring(0, 2);
            string SecondSetSubStr = Input2.Substring(0, 2);
            string Result;
            Input1 = Input1.Remove(0, 2);
            Input2 = Input2.Remove(0, 2);

            Input1 = $"{SecondSetSubStr}{Input1} ";
            Input2 = $"{FirstSetSubStr}{Input2}";

            Console.WriteLine($"{Input1}{Input2}");
        }
        #endregion

        #region 27. Create a single string from two given strings, separated by a space and swap the first 'K' characters of each string.
        public static void SwapFirstKChar(string Input1, string Input2, int K)
        {
            string FirstSetSubStr = Input1.Substring(0, K);
            string SecondSetSubStr = Input2.Substring(0, K);
            string Result;
            Input1 = Input1.Remove(0, K);
            Input2 = Input2.Remove(0, K);

            Input1 = $"{SecondSetSubStr}{Input1} ";
            Input2 = $"{FirstSetSubStr}{Input2}";

            Console.WriteLine($"{Input1}{Input2}");
        }
        #endregion

        #region 28. Write a program to add 'ing' at the end of a given string (length should be at least 3).
        // If the given string already ends with 'ing' then add 'ly' at the end. If the length of the given string is less than 3,
        // leave it unchanged.
        private static void StrAppend(string Input)
        {
            if(Input.Length>3)
            {
                StringBuilder stringBuilder = new StringBuilder();
                if(Input.Substring(Input.Length-3, 3) == "ing")
                {
                    Input += "ly";
                }
                else
                {
                    Input += "ing";
                }
                Console.WriteLine(Input);
            }
            else
            {
                Console.WriteLine($"there are no changes in the given {Input} input due to length is less than 3.");
            }
        }
        #endregion

        #region 29. Write code to remove the character at the nth index in a given string.
        private static void RemoveNthChar(string Input, int Npos)
        {
            string Result;
            if(Input.Length>Npos)
            {
                Result = Input.Remove(Npos,1);
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Input string don't have the provided Nth position at the moment.");
            }
        }
        #endregion

        #region 30. Write code to remove the characters that occur at odd/even indices in a given string.
        public static void RemoveCharAtOddIndices(string Input)
        {
            string Result = string.Empty;
            char[] chars = Input.ToCharArray();
            for(int i=0; i<chars.Length;i++)
            {
                if (i%2==0)
                {
                    Result += chars[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }

        public static void RemoveCharAtEvenIndices(string Input)
        {
            string Result = string.Empty;
            char[] chars = Input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Result += chars[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 31. Write code to reverse a given string.
        public static void ReverseString(string Input)
        {
            char[] chars = Input.ToCharArray();
            char[] Result = new char[chars.Length];
            int j = 0;
            for(int i=chars.Length-1;i>=0;i--, j++)
            {
                Result[j] += chars[i];
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 32. Write code to reverse a given string in place (without using additional space)
        private static char[] ReverseWithoutSpace(string Input)
        {
            char[] chars = Input.ToCharArray();
            int j = 0;
            char temp;
            for (int i = chars.Length - 1; j<chars.Length/2; i--, j++)
            {
                temp = chars[j];
                chars[j] = chars[i];
                chars[i] = temp;
            }
            return chars;
        }
        #endregion

        #region 33. Write code to print the occurrence frequency of all the unique words in a given sentence.
        public static void Unique_Words(string Input)
        {
            Dictionary<string, int> MyList = new Dictionary<string, int>();
            string[] StrArray = Input.Split();
            for(int i=0; i<StrArray.Length;i++)
            {
                //char[] chars = new char[Input.Length];
                if (!(MyList.ContainsKey(StrArray[i])))
                {
                    MyList.Add(StrArray[i], 1);
                }
                else
                {
                    MyList[StrArray[i]] += 1;
                }
            }
            foreach(var item in MyList)
            {
                Console.Write(item.Key + " ");
            }
        }
        #endregion

        #region 34. Write code to print the given string in all upper case / all lower case without using built-in functions.
        //Print all upper case.
        private static void PrintUpperCase(string Input)
        {
            char[] chars = Input.ToCharArray();
            
            for(int i=0; i<chars.Length;i++)
            {
                if (chars[i]>=97 && chars[i]<=122)
                {
                    chars[i] = (char)((int)chars[i] - 32);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(chars);
        }
        //Print all lowercases
        private static void PrintLowerCase(string Input)
        {
            char[] chars = Input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 97 && chars[i] <= 122)
                {
                    chars[i] = (char)((int)chars[i] - 32);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(chars);
        }
        #endregion

        #region 35. Write code to convert the given sentence to Sentence Case (Capitalize the first letter of each word).
        private static void CapitalizeFirstLetter(string Input)
        {
            string[] StrArray = Input.Split();
            string Result = string.Empty;
            for(int i=0, j=0; i<StrArray.Length;i++)
            {
                char[] chars = StrArray[i].ToCharArray();
                if (chars[j]>=97 && chars[j]<=122)
                {
                    chars[j] = (char)((int)chars[j] - 32);
                }
                else
                {
                    continue;
                }
                for(int k=0;k<chars.Length;k++)
                {
                    Result += chars[k];
                }
                Result += " ";
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 36. Write code to reverse every word in a givne sentenace.
        private static void Reverse_Word(string Input)
        {
            string[] StrArray = Input.Split();
            int j = 0;
            string temp;
            for(int i=StrArray.Length-1;j<StrArray.Length/2; i--, j++)
            {
                temp = StrArray[j];
                StrArray[j] = StrArray[i];
                StrArray[i] = temp;
            }
            foreach(string value in StrArray)
            {
                Console.Write(value+" ");
            }
        }
        #endregion

        #region 37. Write code to find if the given string is a palindrome
        private static bool FindPalindrome(string Input)
        {
            bool IsPalindrome = false;
            if(Input == ReverseWithoutSpace(Input).ToString())
            {
                IsPalindrome = true;
            }
            return IsPalindrome;
        }
        #endregion

        #region 38. Write code to check if the two given strings form an anagram (e.g. binary and brainy. Same chars used exactly once).
        private static void CheckIfAnagram(string Input1, string Input2)
        {
            if(Input1.Length == Input2.Length)
            {
                bool IsAnagram = true;
                char[] chars1 = Input1.ToLower().ToCharArray();
                char[] chars2 = Input2.ToLower().ToCharArray();

                Array.Sort(chars1);
                Array.Sort(chars2);

                for(int i=0; i<chars1.Length;i++)
                {
                    if (chars1[i] != chars2[i])
                    {
                        IsAnagram = false;
                        break;
                    }
                }
                Console.WriteLine(IsAnagram);
            }
            else
            {
                Console.WriteLine("Both strings are not anagram string");
            }
        }
        #endregion

        #region 39. Write code to check if the given string contains all 26 alphabets in any case.
        private static void CheckIfAllAlphabets(string Input)
        {
            char[] chars = Input.ToLower().ToCharArray();
            Array.Sort(chars);
            List<char> MyList = new List<char>();
          
            if(chars.Length>=26)
            {
                for(int i=0;i<chars.Length;i++)
                {
                    if (!MyList.Contains(chars[i]))
                    {
                        if (chars[i]>=97 && chars[i]<= 122)
                        {
                            MyList.Add(chars[i]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Input value does not meet at lease 26 count.");
            }
        }
        #endregion

        #region 40. Write a function that takes a list of words and returns the longest word and its length.
        private static void ReturnLongestWord(string Input)
        {
            string[] StrArray = Input.Split();
            string Result = string.Empty;
            int LongestWordlength = 0;
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            for(int i=0; i<StrArray.Length;i++)
            {
                if (!(MyDict.ContainsKey(StrArray[i])))
                {
                    MyDict.Add(StrArray[i], StrArray[i].Length);
                    if (MyDict[StrArray[i]]> LongestWordlength)
                    {
                        LongestWordlength = MyDict[StrArray[i]];
                        Result = $"{StrArray[i]}: {LongestWordlength}";
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 41. Write a function that takes a list of words and returns the shortest word and its length.
        private static void ReturnShortestWord(string Input)
        {
            string[] StrArray = Input.Split();
            string Result = string.Empty;
            int ShortestWordlength = int.MaxValue;
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            for (int i = 0; i < StrArray.Length; i++)
            {
                if (!(MyDict.ContainsKey(StrArray[i])))
                {
                    MyDict.Add(StrArray[i], StrArray[i].Length);
                    if (MyDict[StrArray[i]] < ShortestWordlength)
                    {
                        ShortestWordlength = MyDict[StrArray[i]];
                        Result = $"{StrArray[i]}: {ShortestWordlength}";
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 42. Write a function that takes a sentence and returns only those words that contains 4 or more characters.
        private static void FourOrMoreChar(string Input)
        {
            string[] StrArray = Input.Split();
            string Result = string.Empty;
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            for(int i=0; i<StrArray.Length;i++)
            {
                if (!(MyDict.ContainsKey(StrArray[i])))
                {
                    MyDict.Add(StrArray[i], (int)StrArray[i].Length);
                    if (MyDict[StrArray[i]]>=4)
                    {
                        Result = $"{StrArray[i]}: {StrArray[i].Length}";
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine(Result);
            }
            
        }
        #endregion

        #region 43. Write a function that takes a sentence and returns only those words that contains K or more characters.
        private static void KthOrMoreChar(string Input, int K)
        {
            string[] StrArray = Input.Split();
            string Result = string.Empty;
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            for (int i = 0; i < StrArray.Length; i++)
            {
                if (!(MyDict.ContainsKey(StrArray[i])))
                {
                    MyDict.Add(StrArray[i], (int)StrArray[i].Length);
                    if (MyDict[StrArray[i]] >= K)
                    {
                        Result = $"{StrArray[i]}: {StrArray[i].Length}";
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine(Result);
            }

        }
        #endregion

        #region 44. Write code to remove the first occurrence of a dirty word from a given sentence.
        private static void RemoveDirtyWord(string Word, string Dirty)
        {
            string[] Words = Word.Split();
            int Count = 0;
            string Result = string.Empty;
            for(int i=0; i<Words.Length;i++)
            {
                if ((Words[i]==Dirty) && Count==0)
                {
                    Count++;
                    continue;
                }
                else
                {
                    Result += $"{Words[i]} ";
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region 45. Write code to remove all occurrences of a dirty word from a given sentence and notify how many were removed.
        private static void RemoveAllDirtyWords(string word, string Dirty)
        {
            string[] Words = word.Split();
            int Count = 0;
            string Result = string.Empty;
            for(int i=0; i<Words.Length;i++)
            {
                if (Words[i]==Dirty)
                {
                    Count++;
                }
                else
                {
                    Result += $"{Words[i]} ";
                }
            }
            Console.WriteLine($"{Result}, {Count} number of dirty words were removed.");
        }
        #endregion

        #region 46. Write code to find the most repeated word in a given sentence.
        private static void MostRepeated(string Input)
        {
            string[] Words = Input.Split();
            var Result = MyDict(Words).OrderByDescending(x => x.Value).First();
            //int MostCount = int.MinValue;
            //string Result = string.Empty;
            //Dictionary<string, int> MyDict = new Dictionary<string, int>();
            //for(int i=0; i<StrArray.Length;i++)
            //{
            //    if (!(MyDict.ContainsKey(StrArray[i])))
            //    {
            //        MyDict.Add(StrArray[i], 1);
            //    }
            //    else
            //    {
            //        MyDict[StrArray[i]]++;
            //    }
            //}
            //foreach(var item in MyDict.OrderByDescending(x => x.Value ))
            //{                
            //    for (int i = 0; i < item.Value; i++)
            //    {
            //        if (i == 0)
            //        {
            //            Result = $"{item.Key}: {item.Value}";
            //        }
            //    }                
            //}
            Console.WriteLine(Result);
        }
        #endregion

        #region 47. Write code to find the second most repeated word in a given sentence.
        private static void SecondMostRepeated(string Sentence)
        {
            string[] Words = Sentence.Split();
            var Result = MyDict(Words).OrderByDescending(x => x.Value).Skip(1).FirstOrDefault();
            //string Result = string.Empty;
            //Dictionary<string, int> MyDict = new Dictionary<string, int>();
            //for(int i=0; i< Words.Length;i++)
            //{
            //    if (!(MyDict.ContainsKey(Words[i])))
            //    {
            //        MyDict.Add(Words[i], 1);
            //    }
            //    else
            //    {
            //        MyDict[Words[i]]++;
            //    }
            //    foreach (var item in MyDict.OrderByDescending(x => x.Value))
            //    {
            //        for (int j = 0 ; j  < item.Value; j++)
            //        {
            //            if (j == 1)
            //            {
            //                Result = $"{item.Key}: {item.Value}";
            //            }
            //        }                    
            //    }
            //}
            Console.WriteLine(Result);
        }
        #endregion

        #region 48. Write code to find the least repeated word in a given sentence.
        private static void LeastRepeatedWord(string Sentence)
        {
            string[] Words = Sentence.Split();
            var result = MyDict(Words).OrderBy(x => x.Value).First().Key;
            Console.WriteLine($"{Words}: {Words}");
            //foreach(var item in MyDict(Words).OrderBy(x => x.Value))
            //{
            //    for(int j = 0; j < MyDict(Words).Count ;j++)
            //    {
            //        if(j == 0)
            //        {
            //            Console.WriteLine($"{item.Key}: {item.Value}");
            //            break;
            //        }                    
            //    }
            //    break;
            //}
        }

        #endregion

        #region My Dictionary
        public static Dictionary<string, int> MyDict(string[] Words)
        {
            Dictionary<string, int> MyDict = new Dictionary<string, int>();
            for (int i = 0; i < Words.Length; i++)
            {
                if (!(MyDict.ContainsKey(Words[i])))
                {
                    MyDict.Add(Words[i], 1);
                }
                else
                {
                    MyDict[Words[i]]++;
                }
            }
            return MyDict;
        }
        #endregion

        #region 49. Write code to print those words that appear more than k times in a given sentence.
        
        #endregion
    }
}