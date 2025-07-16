using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        foreach (var c in array)
        {
            if (c > height)
            {
                answer++;
            }
        }
        return answer;
    }
}