using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsorted_Integer_Arrays
{
    internal class StringDemo
    {
        #region String Conversation
        private static void StringConversation(string Input)
        {
            string Result = string.Empty;
            TextInfo CurrentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo EnglishTextInfo = new CultureInfo("en-US", false).TextInfo;
            Result = EnglishTextInfo.ToTitleCase(Input);
            Console.WriteLine(Result);
        }
        #endregion

        #region String as array
        private static void StringAsArray(string Input)
        {
            for (int i = 0; i < Input.Length; i++)
            {
                Console.WriteLine(Input[i]);
            }
        }
        #endregion

        #region EscapeString
        private static void EscapeString()
        {
            string Result;
            Result = "This is my \"test\" solution.";
            Console.WriteLine(Result);

            Result = "C:\\Demo\\Test.txt";
            Console.WriteLine(Result);

            Result = @"C:\Demo\Test.txt";
            Console.WriteLine(Result);
        }

        #endregion

        #region Appending Strings, Formatting and string Interpolation and String Concatenation Performance
        private static void AppendingStrings()
        {
            string firstName = "Arun";
            string SecondName = "Kumar";
            string fullName;

            fullName = firstName + ", My name is " + firstName + " " + SecondName;
            Console.WriteLine(fullName);

            //Formatting
            fullName = string.Format("{0}, My name is {0} {1}", firstName, SecondName);
            Console.WriteLine("{0}, My name is {0} {1}", firstName, SecondName);
            Console.WriteLine(fullName);

            //String Interpolation
            fullName = $"{firstName}, My name is {firstName} {SecondName}";
            Console.WriteLine(fullName);
        }
        #endregion

        #region String InterPolation and Literal
        private static void InterpolationAndLiteral()
        {
            string Input = "Arunkumar";
            string Result = $@"C:\Demo\{Input}\{"\""}Test{"\""}.txt";
            Console.WriteLine(Result);
        }
        #endregion

        #region String memory and time usage with concantenation
        private static void StringBuilder()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string test = "";

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }

            stopWatch.Stop();
            Console.WriteLine($"Regular Stop watch: {stopWatch.ElapsedMilliseconds}ms");

            Stopwatch builderStopWatch = new Stopwatch();
            builderStopWatch.Start();

            StringBuilder sb = new();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }

            stopWatch.Stop();
            Console.WriteLine($"Builder Stop watch: {builderStopWatch.ElapsedMilliseconds}ms");

        }
        #endregion

        #region Converting Array to string concat()
        private static void WorkingWithArrays()
        {
            int[] values = new int[] { 3, 5, 8, 7, 6 };
            string Result;

            //using string concat
            Result = string.Concat(values);
            Console.WriteLine(Result);

            //Using string join
            Result = string.Join(", ", values);
            Console.WriteLine(Result);

            //using Split()
            string TestString = "Arun,kumar,jai,yoga,mallika";
            string[] StrArray = TestString.Split(',');

            Array.ForEach(StrArray, x => Console.WriteLine(x));

            Console.WriteLine();

        }
        #endregion

        #region Remove string whitespaces using Trim
        private static void PadAndTrim()
        {
            string Input = "      Hello World        ";
            string Result;

            //Trim whitespaces on both sides
            Result = Input.TrimStart();
            Console.WriteLine($"'{Result}'");

            Result = Input.TrimEnd();
            Console.WriteLine($"'{Result}'");

            Result = Input.Trim();
            Console.WriteLine($"'{Result}'");

            //Padding a string using Pad()
            Input = "1.15";

            Result = Input.PadLeft(10, '0');
            Console.WriteLine(Result);

            Result = Input.PadRight(10, '0');
            Console.WriteLine(Result);
        }
        #endregion

        #region Searching Methods: StartsWith and EndsWith
        private static void SearchingStrings()
        {
            string TestString = "This is a test of the search.  Let's see how it's testing works out.";
            bool ResultBool;
            int ResultInt;

            //Search: StartsWith
            ResultBool = TestString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {ResultBool}");

            ResultBool = TestString.StartsWith("ThIs is");
            Console.WriteLine($"Starts with \"ThIs is\": {ResultBool}");

            //Search: EndsWith
            ResultBool = TestString.EndsWith("works out.");
            Console.WriteLine($"Ends with \"works out.\": {ResultBool}");

            ResultBool = TestString.EndsWith("works Out.");
            Console.WriteLine($"Ends with \"works out.\": {ResultBool}");

            //Search: Contains
            ResultBool = TestString.Contains("test");
            Console.WriteLine($"Contains \"test\": {ResultBool}");

            ResultBool = TestString.StartsWith("ThIs is");
            Console.WriteLine($"Contains \"tests\": {ResultBool}");

            //Search: IndexOf
            ResultInt = TestString.IndexOf("test");
            Console.WriteLine($"IndexOf \"test\": {ResultInt}");

            //After character 11
            ResultInt = TestString.IndexOf("test", 11);
            Console.WriteLine($"IndexOf \"tests\" after character 10: {ResultInt}");

            //After character 51th if does not return -1
            ResultInt = TestString.IndexOf("test", 51);
            Console.WriteLine($"IndexOf \"tests\" after character 51: {ResultInt}");

            //Search: LastIndexOf
            ResultInt = TestString.LastIndexOf("test");
            Console.WriteLine($"LastIndexOf \"test\": {ResultInt}");

            //Before character of 50
            ResultInt = TestString.LastIndexOf("test", 50);
            Console.WriteLine($"LastIndexOf \"tests\" before character 50: {ResultInt}");

            //Before character 10th if does not return -1
            ResultInt = TestString.LastIndexOf("test", 10);
            Console.WriteLine($"LastIndexOf \"tests\" before character 10: {ResultInt}");

            //while(TestString.IndexOf("test", i)>-1)
            //{

            //}
        }
        #endregion

        #region Allow nullable strings in your application
        private static void OrderingStrings()
        {
            CompareToHelper("Arun", "Kumar");
            CompareToHelper("Arun", null);
            CompareToHelper("Arun", "Arun");
            CompareToHelper("Arun", "Arunkumar");

            Console.WriteLine();

            CompareHelper("Arun", "Kumar");
            CompareHelper("Arun", null);
            CompareHelper(null, "Kumar");
            CompareHelper("Arun", "Smart");
            CompareHelper("Arun", "Arun");
            CompareHelper("Arun", "Arunkumar");
            CompareHelper(null, null);
        }

        private static void CompareToHelper(string TestA, string? testB)
        {
            int ResultInt = TestA.CompareTo(testB);
            switch (ResultInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: {testB ?? "null"} comes before {TestA}");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: {TestA} comes before {testB}");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: {TestA} is the same as {testB}");
                    break;
            }
        }

        private static void CompareHelper(string? TestA, string? TestB)
        {
            int ResultInt = String.Compare(TestA, TestB);

            switch (ResultInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: {TestB ?? "null"} comes before {TestA}");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: {TestA ?? "null"} comes before {TestB}");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: {TestA ?? "null"} is the same as {TestB ?? "null"}");
                    break;
            }
        }
        #endregion

        #region Comparing String Equality: Equals()
        private static void TestingEquality()
        {
            EqualityHelper("Arun", "kumar");
            EqualityHelper("Arun", null);
            EqualityHelper(null, " ");
            EqualityHelper("", " ");
            EqualityHelper("Arun", "Arun");
            EqualityHelper("Arun", "arun");

        }
        private static void EqualityHelper(string? TestA, string? TestB)
        {
            bool ResultBoolean;

            //Using Equals
            ResultBoolean = string.Equals(TestA, TestB);

            if (ResultBoolean)
            {
                Console.WriteLine($"Equals: '{TestA ?? "null"}' equals '{TestB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals: '{TestA ?? "null"}' does not equals '{TestB ?? "null"}'");
            }

            Console.WriteLine();

            //Using Equals with ignore case
            ResultBoolean = string.Equals(TestA, TestB, StringComparison.InvariantCultureIgnoreCase);

            if (ResultBoolean)
            {
                Console.WriteLine($"Equals (Ignore case): '{TestA ?? "null"}' equals '{TestB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"Equals (Ignore case): '{TestA ?? "null"}' does not equals '{TestB ?? "null"}'");
            }

            Console.WriteLine();

            // using == Operator
            ResultBoolean = TestA == TestB;

            if (ResultBoolean)
            {
                Console.WriteLine($"==: '{TestA ?? "null"}' equals '{TestB ?? "null"}'");
            }
            else
            {
                Console.WriteLine($"==: '{TestA ?? "null"}' does not equals '{TestB ?? "null"}'");
            }
        }
        #endregion

        #region Retrieve a part of string: Substring
        private static void GettingASubString()
        {
            string TestString = "This is a test of substring.  Let's see how it's testing works out";
            string Result;

            Result = TestString.Substring(5);
            Console.WriteLine(Result);

            Result = TestString.Substring(5, 4);
            Console.WriteLine(Result);
        }
        #endregion

        #region Replace a part of string: Replace
        private static void ReplacingText()
        {
            string TestString = "This is a test of replace.  Let's see how it's testing works out for test.";
            string Result;

            Result = TestString.Replace("test", "trial");
            Console.WriteLine(Result);

            Result = TestString.Replace(" test ", " trial ");
            Console.WriteLine(Result);

            Result = TestString.Replace("Works", "makes", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(Result);
        }
        #endregion

        #region Insert text in a string: Insert
        private static void InsertingText()
        {
            string TestString = "This is a test of insert.  Let's see how it's testing works out for test.";
            string Result;

            Result = TestString.Insert(5, "(test)");
            Console.WriteLine(Result);
        }
        #endregion

        #region Remove text from a string: Remove
        private static void RemovingText()
        {
            string TestString = "This is a test of Remove.  Let's see how it's testing works out for test.";
            string Result;

            Result = TestString.Remove(24);
            Console.WriteLine(Result);

            Result = TestString.Remove(14, 10);
            Console.WriteLine(Result);
        }
        #endregion


        #region String Demos
        public static void PrintString()
        {

            #region Print string
            //init using string literal
            string s1 = "Arun";
            //Console.WriteLine(s1);

            //assigning one string to another
            string s2 = s1;
            //Console.WriteLine(s2);

            //init using a char array
            char[] charstring = new char[] { 'A', 'r', 'u', 'n' };
            string s3 = new string(charstring);
            //Console.WriteLine(s3);

            //init using repeated char values
            string s4 = new string('A', 20);
            //Console.WriteLine(s4);

            //init using char array with index and length
            //string s5 = new string(charstring, 2, 3);
            //Console.WriteLine(s5);
            #endregion

            #region Split

            ////space as separator
            //string s6 = "33 44 55";
            //string[] input = s6.Split(' ');
            //Console.WriteLine(input[0] + input[1] + input[2]);

            ////multiple separators
            //string s7 = "33 44,55";
            //string[] input1 = s7.Split(' ', ',');
            //Console.WriteLine(input1[0] + input1[1] + input1[2]);

            #endregion

            #region Substring

            ////Substring

            string s8 = "I am Arun from Trichy";
            string s9 = s8.Substring(5);
            //Console.WriteLine(s9);
            //string s10 = s8.Substring(5, 5);
            //Console.WriteLine(s10);

            #endregion

            #region StartsWith

            //if (s8.StartsWith("I am"))
            //{
            //    Console.WriteLine("True: It starts with I am");
            //}
            //else
            //{
            //    Console.WriteLine("False: Doesn't start with I am");
            //}

            #endregion

            #region Case-sensitive by Default
            //case sensitive by default
            //if (s8.StartsWith("i Am"))
            //{
            //    Console.WriteLine("True: It starts with i Am");
            //}
            //else
            //{
            //    Console.WriteLine("False: Doesn't start with i Am");
            //}
            #endregion

            #region MyRegion Ignore case and compare
            ////ignore case and compare
            //if (s8.StartsWith("i Am", true, System.Globalization.CultureInfo.CurrentCulture))
            //{
            //    Console.WriteLine("True: It starts with I am");
            //}
            //else
            //{
            //    Console.WriteLine("False: Doesn't start with I am");
            //}
            #endregion

            #region EndsWith
            //ends with

            //if (s8.EndsWith("Trichy"))
            //{
            //    Console.WriteLine("True: Ends with Trichy");
            //}
            //else
            //{
            //    Console.WriteLine("False: Doens't end with Trichy");
            //}

            #endregion

            #region Contains Method
            ////Contains method
            //if (s8.Contains("Arun"))
            //{
            //    Console.WriteLine("True: Contains Arun");
            //}
            //else
            //{
            //    Console.WriteLine("False: Doesn't Contain Arun");
            //}

            #endregion

            #region ElementAt, String.Join, Distinct and Distinct returns IEnumerable<char>

            ////ElementAt
            //char x = s8.ElementAt(5);
            //Console.WriteLine(x);

            ////String.Join
            //string[] mystrings = new string[] { "I", "am", "Arun", "from", "Trichy" };
            //Console.WriteLine(string.Join(":", mystrings));

            ////Distinct
            //char[] s11 = s8.Distinct().ToArray();
            //string s12 = new string(s11);
            //Console.WriteLine(s12);

            //Distinct returns IEnumerable<char>
            //foreach (char cc in s8.Distinct())
            //{
            //    Console.Write(cc + ", ");
            //}

            #endregion

            #region IndexOf()
            // //indexof
            //int LocationOfA = s8.IndexOf("A");
            //Console.WriteLine(LocationOfA);
            //int LocationOfa = s8.IndexOf("a");
            //Console.WriteLine(LocationOfa);
            //int LocationOfa1 = s8.IndexOf("a", 3);
            //Console.WriteLine(LocationOfa1);
            //int LocationOfArun = s8.IndexOf("Arun");
            //Console.WriteLine(LocationOfArun);
            #endregion

            #region Insert and Replace
            ////Insert
            //string s13 = s8.Insert(9, "kumar");
            //Console.WriteLine(s13);

            //replace
            //string samplestring = "Sample {String} is CoMPleX";
            ////Console.WriteLine(samplestring);
            //string s14 = samplestring.Replace("{", "").Replace("}", "");
            ////Console.WriteLine(s14);
            #endregion

            #region ToLower, ToUpper and Reverse
            ////ToLower
            //string s15 = s14.ToLower();
            //Console.WriteLine(s15);

            ////ToUpper
            //string s16 = s14.ToUpper();
            //Console.WriteLine(s16);

            ////Reverse
            //char[] c1 = s14.Reverse().ToArray();
            //string s17 = new string(c1);
            //Console.WriteLine(s17);
            #endregion            
        }
        #endregion
    }
}
