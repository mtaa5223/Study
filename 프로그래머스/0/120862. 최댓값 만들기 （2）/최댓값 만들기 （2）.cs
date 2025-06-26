public class Solution {
    public int solution(int[] numbers) {
        int max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++) {
            for (int j = i + 1; j < numbers.Length; j++) {
                int product = numbers[i] * numbers[j];
                if (product > max) {
                    max = product;
                }
            }
        }

        return max;
    }
}
