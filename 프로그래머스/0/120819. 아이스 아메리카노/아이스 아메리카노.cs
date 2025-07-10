using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int money) {
        List<int> answer = new List<int>();

            answer.Add(money / 5500);
        answer.Add(money % 5500);
        
        return answer.ToArray();
    }
}