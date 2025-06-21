using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        for (int i = 0; i < n; i++)
        {
            answer += my_string[i];
        }
        return answer;
    }
}