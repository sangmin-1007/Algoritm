using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int temp;
        
        for(int i = 0; i < s.Length; i++)
        {
            temp = -1;
            
            for(int j = i-1; j>=0; j--)
            {
                if(s[i] == s[j])
                {
                    temp = i-j;
                    break;
                }
            }
            
            answer[i] = temp;
        }
        
        return answer;
    }
}