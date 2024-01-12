using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string result = n.ToString();
        for(int i = 0; i<result.Length; i++)
        {
            answer += (int)Char.GetNumericValue(result,i);
        }
        return answer;
    }
}