using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int roller = 0;
        for(int i = 0; i < section.Length; i++)
        {
            if(section[i] > roller)
            {
                if(section[i] > roller)
                {
                    roller = section[i] + m - 1;
                    answer++;
                }
            }
        }
        
        return answer;
    }
}