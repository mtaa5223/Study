using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        List<int> answer = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i >= num1 && i <= num2)
            {
                answer.Add(numbers[i]);
            }
        }
        return answer.ToArray();
    }
}