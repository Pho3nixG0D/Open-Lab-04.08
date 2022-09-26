using NUnit.Framework.Internal.Execution;
using System;
using System.Diagnostics.Tracing;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int countl = 0;
            int x = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    countl++;
                }
            }
            string[] resultArray = new string[countl];

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    resultArray[x] = strings[i];
                    x++;
                }
            }
            return resultArray;

        }
    }
}
