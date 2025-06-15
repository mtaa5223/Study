using System;

public class Solution {
    public int solution(string myString, string pat) {
        string a = myString.ToUpper();
        string b = pat.ToUpper();
        return a.Contains(b) ? 1 : 0;
    }
}
