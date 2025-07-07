using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string b = order.ToString();

        for (int i = 0; i < b.Length; i++)
        {
            int c = int.Parse(b[i].ToString());
            if (c % 3 == 0 && c != 0)
            {
                answer++;
            }
        }
        return answer;
    }
}