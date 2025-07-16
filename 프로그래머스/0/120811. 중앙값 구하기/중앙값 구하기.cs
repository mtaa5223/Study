using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        Array.Sort(array);
        if (array.Length % 2 == 0)
        {
            answer = array[array.Length / 2];
        }
        else
        {
            answer = array[array.Length / 2];
        }
           
        return answer;
    }
}