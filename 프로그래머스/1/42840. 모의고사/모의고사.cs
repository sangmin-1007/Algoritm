using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] answers) {
        List<int> answer = new List<int>();
        
        int[] num1 = new int[]{1,2,3,4,5};
        int[] num2 = new int[]{2,1,2,3,2,4,2,5};
        int[] num3 = new int[]{3,3,1,1,2,2,4,4,5,5};
        
        int temp1 = 0;
        int temp2 = 0;
        int temp3 = 0;
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == num1[i % num1.Length])
            {
                temp1++;
            }
            if(answers[i] == num2[i % num2.Length])
            {
                temp2++;
            }
            if(answers[i] == num3[i % num3.Length])
            {
                temp3++;
            }
        }
        
        Dictionary<int,int> rank = new Dictionary<int,int>()
        {
            {1,temp1},
            {2,temp2},
            {3,temp3}
        };
        
        var maxTemp = rank.Values.Max();
        
        foreach (var item in rank )
        {
            if(item.Value == maxTemp)
            {
                answer.Add(item.Key);
            }
        }
        
        return answer;
    }
}