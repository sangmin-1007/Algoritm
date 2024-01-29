public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int min = n;
        int max = m;
        int gcd = 0;
        while(m > 0)
        {
            int temp = n;
            n = m;
            m = temp % m;
            gcd = n;
            
        }
        answer[0] = gcd;
        answer[1] = min * max / gcd;
        return answer;
    }
}