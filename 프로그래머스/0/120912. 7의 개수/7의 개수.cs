using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string b = array[i].ToString();
            foreach (char c in b)
            {
                if (c == '7')
                {
                    answer++;
                }
            }    
         
        }
        return answer;
    }
}