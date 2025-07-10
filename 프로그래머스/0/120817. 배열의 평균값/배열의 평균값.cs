using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        double c = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
           c  +=  numbers[i];
           
        }
        answer = c/ numbers.Length;
        return answer;
    }
}