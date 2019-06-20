using System;

//This class will be called in the Main Console to Ask the user 
public static class Ask
{
        public static string ForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int ForInteger(string prompt)
        {
            return int.Parse(ForString(prompt));
        }

        public static bool ForBool(string prompt)
        {
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }

    }

