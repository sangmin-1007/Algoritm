using System;

public class Solution {
    public bool solution(int x) {
        bool answer = true;
        string temp = x.ToString();
        int sum = 0;
        for(int i = 0; i<temp.Length; i++)
        {
            sum += (int)Char.GetNumericValue(temp,i);
        }
        
        if(x%sum == 0)
            return answer;
        else
        {
            answer = false;
            return answer;
        }
        
    }
}