using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        char[] charArray = my_string.ToCharArray();
        Array.Reverse(charArray);
        answer = new string(charArray);
        return answer;
    }
}