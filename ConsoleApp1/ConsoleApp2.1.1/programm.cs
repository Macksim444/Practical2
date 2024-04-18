namespace ConsoleApp3;
using System;

public class programm
{
    static int goldSearch(string gold, string stowns)
    {
        int sum = 0;
        for (int i = 0; i < gold.Length; i++)
        {
            for (int j = 0; j < stowns.Length; j++)
            {
                if (gold[i] == stowns[j])
                {
                    sum++;
                }
            }
        }

        return sum;
    }
    public static void Main()
    {
        string gold = Console.ReadLine();
        string stowns = Console.ReadLine();
        int result = goldSearch(gold, stowns);
        Console.WriteLine(result);
    }
}