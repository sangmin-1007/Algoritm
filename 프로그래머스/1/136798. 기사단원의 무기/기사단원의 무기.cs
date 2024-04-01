using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int[] atk = new int[number + 1];
        
        for(int i = 1; i <= number; i++)
        {
            for(int j = i; j <= number; j += i)
            {
                atk[j]++;
            }
        }
        
        for(int i = 1; i <= number; i++)
        {
            if(atk[i] > limit)
                answer += power;
            else
                answer += atk[i];
        }
        
        return answer;
    }
}