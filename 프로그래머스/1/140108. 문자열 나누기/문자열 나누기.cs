using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int same = 0;
        int diff = 0;
        char start = ' ';
        
        for(int i = 0; i < s.Length; i++)
        {
            if(i == 0)
            {
                start = s[i];
                same++;
            }
            else if(start == s[i])
            {
                same++;
            }
            else
            {
                diff++;
            }
            
            if(same == diff && i < s.Length - 1)
            {
                start = s[i + 1];
                same = 0;
                diff = 0;
                answer++;
            }
            
            if(i == s.Length - 1)
            {
                    answer++;

            }
            
        }
        
        return answer;
    }
}