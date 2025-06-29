using System;

public class Solution {
    public string solution(string rny_string) {
        string answer = "";
        for (int i = 0; i < rny_string.Length; i++)
        {
            if (rny_string[i] == 'm')
            {
                answer += "rn";
            }
            else
            {
                answer += rny_string[i];
            }
        }
        return answer;
    }
}