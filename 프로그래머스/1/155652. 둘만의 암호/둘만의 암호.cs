using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        char ch;
        int temp = 0;
        for(int i = 0; i < s.Length; i++)
        {
            temp = s[i];
            for(int j = 0; j < index; j++)
            {
                
                temp++;
                if(temp > 122)
                {
                    temp = 97;
                }
                ch = Convert.ToChar(temp);
                if(skip.Contains(ch))
                {
                    j = j - 1;
                }
            }
            
            
            ch = Convert.ToChar(temp);
            answer += ch;
        }
        return answer;
    }
}