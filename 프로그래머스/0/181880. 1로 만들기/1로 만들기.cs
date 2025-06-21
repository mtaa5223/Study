using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;

        foreach (int num in num_list)
        {
            int n = num;
            while (n > 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else  
                    n = (n - 1) / 2;

                answer++; 
            }
        }

        return answer;
    }
}
