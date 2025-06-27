using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list) {
        List<int> answer = new List<int>();
        int b = 0; 
        int c = 0;
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                b++;
            }
            else
            {
                c++;
            }
        }
        answer.Add(b);
        answer.Add(c);
        return answer.ToArray();
    }
}