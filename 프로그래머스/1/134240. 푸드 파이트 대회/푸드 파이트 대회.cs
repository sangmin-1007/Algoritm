using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string sTemp = "";
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                answer += i.ToString();
            }
        }
        
        sTemp = string.Concat(answer.Reverse());
        
        return answer + "0" + sTemp;
    }
}