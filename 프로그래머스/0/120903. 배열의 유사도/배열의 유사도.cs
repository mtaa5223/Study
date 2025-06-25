using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        for (int i = 0; i < s2.Length; i++)
        {
            foreach (var c in s1)
            {
                if (s2[i] == c)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}