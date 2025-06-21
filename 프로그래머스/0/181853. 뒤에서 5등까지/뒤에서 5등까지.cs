using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        Array.Sort(num_list);
        return num_list.Take(5).ToArray();
    }
}