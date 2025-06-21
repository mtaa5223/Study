using System;
using System.Text;

public class Solution {
    public string solution(string myString) {
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < myString.Length; i++)
        {
            char c = myString[i];

            if (c == 'a')
            {
                answer.Append('A');
            }
            else if (c != 'A' && char.IsUpper(c))
            {
                answer.Append(char.ToLower(c));
            }
            else
            {
                answer.Append(c);
            }
        }

        return answer.ToString();
    }
}
