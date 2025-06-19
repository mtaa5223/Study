using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int[] indices) {
 
        Array.Sort(indices);
        Array.Reverse(indices);

        string answer = my_string;
        foreach (int index in indices)
        {
            answer = answer.Remove(index, 1);
        }
        return answer;
    }
}
