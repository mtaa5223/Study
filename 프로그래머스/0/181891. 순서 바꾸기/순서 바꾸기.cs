using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> answer = new List<int>();
        for (int i = 1; i <= num_list.Length; i++)
        {
            if (i > n)
            {
                answer.Add(num_list[i-1]);
            }
            
          
            
        }
            for (int i = 1; i <= n; i++)
            {
                answer.Add(num_list[i-1]);   
            }
       
  
            return answer.ToArray();
    }
}