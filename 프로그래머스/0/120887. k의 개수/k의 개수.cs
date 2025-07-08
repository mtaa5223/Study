using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        char kr = k.ToString()[0];
        for (int l = i; l <= j ; l++)
        {
            string b = l.ToString();
            foreach (var c in b)
            {
                if (c == kr)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}