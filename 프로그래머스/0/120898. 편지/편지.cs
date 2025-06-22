using System;

public class Solution {
    public int solution(string message) {
        int answer = 0;
        for (int i = 0; i < message.Length; i++)
        {
            answer += 2;
        }
        return answer;
    }
}