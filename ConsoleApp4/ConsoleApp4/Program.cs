using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<char, int> romanNumber = new Dictionary<char, int>
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };

        string number = Console.ReadLine().ToUpper();
        int tape = 0;
        int sum = 0;
        int prevNum = 0;
        
        for (int i = number.Length - 1; i >= 0; i--)
        {
            tape = romanNumber[number[i]];

            if (tape >= prevNum)
            {
                sum += tape;
            }
            else
            {
                sum -= tape;
            }

            tape = prevNum;
        }
        
        Console.WriteLine(sum);
    }
}
