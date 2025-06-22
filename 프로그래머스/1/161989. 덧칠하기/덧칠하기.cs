using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int PaintEnd = 0;

        foreach (var a in section)
        {
            if (a > PaintEnd)
            {
                PaintEnd = a + m - 1;
                answer++;
            }
        }

        return answer;
    }
}