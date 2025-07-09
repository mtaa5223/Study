using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if(s[i] == s[j]){
                    count++;
                }
            }
            if(count == 1){
                answer += s[i];
            }
        }
        char[] arr = answer.ToCharArray();
        Array.Sort(arr);
            return new string(arr);
    }
}