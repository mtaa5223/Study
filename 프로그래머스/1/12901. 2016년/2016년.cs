public class Solution {
    public string solution(int a, int b) {
        string[] days = { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
        int[] monthDays = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int totalDays = 0;
        for (int i = 1; i < a; i++) {
            totalDays += monthDays[i];
        }

        totalDays += b - 1;

        return days[totalDays % 7];
    }
}
