using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for(int i = 1; i < 10; i++)
        {
            answer += i;
        }
        
        answer -= numbers.Sum();
        return answer;
    }
}