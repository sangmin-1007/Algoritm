using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] speak = {"aya", "ye", "woo", "ma"};
        
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < speak.Length; j++)
            {
                string str = speak[j] + speak[j];
                babbling[i] = babbling[i].Replace(str, "X").Replace(speak[j], " ");
            }
            if(babbling[i].Trim().Length < 1) answer++;
        }
        
        return answer;
    }
}