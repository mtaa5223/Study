using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> answer = new List<string>();

        foreach (string str in strArr)
        {
            if (!str.Contains("ad"))
            {
                answer.Add(str);
            }
        }

        return answer.ToArray();
    }
}
