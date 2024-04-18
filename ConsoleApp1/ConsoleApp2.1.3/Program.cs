using System;

class HelloWorld {
    static bool numsSearch(int[] nums, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int num = nums[i];
            for (int j = 0; j < n; j++)
            {
                if (i != j && num == nums[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
       
        if (numsSearch(nums, n))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}