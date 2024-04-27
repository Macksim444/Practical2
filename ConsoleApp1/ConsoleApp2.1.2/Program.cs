using System;
using System.Collections.Generic;

class HelloWorld {
    static void FindCombinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }
       
        for (int i = start; i < candidates.Length; i++) {
            if (candidates[i] > target) {
                continue;
            }
           
            current.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    static List<List<int>> GetUniqueCombinations(int[] candidates, int target) {
        Array.Sort(candidates); 
        List<List<int>> result = new List<List<int>>();
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }

    static void Main() {
        int[] candidates = {2, 3, 4, 7, 8};
        int target = 5;
       
        List<List<int>> uniqueCombinations = GetUniqueCombinations(candidates, target);
       
        foreach (var combination in uniqueCombinations) {
            foreach (var num in combination) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
