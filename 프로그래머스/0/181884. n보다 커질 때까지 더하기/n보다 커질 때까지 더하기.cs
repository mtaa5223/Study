using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int b = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
             b += numbers[i];
            
            if (b > n)
            {
                answer = b;
                break;
            }
        }
        return answer;
    }
}