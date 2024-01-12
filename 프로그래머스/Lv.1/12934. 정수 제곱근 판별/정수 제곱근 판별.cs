using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        long temp = (long)Math.Sqrt(n);
        
        answer = temp * temp == n ? (temp+1) * (temp+1) : -1;
        return answer;
    }
}