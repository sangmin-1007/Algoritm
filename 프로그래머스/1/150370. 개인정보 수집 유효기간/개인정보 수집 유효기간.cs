using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>();
        DateTime now = DateTime.Parse(today);
        
        string result = "";
        string priResult = "";
        
        for(int i = 0; i < privacies.Length; i++)
        {
            for(int j = 0; j < terms.Length; j++)
            {
                if(terms[j].Contains(privacies[i][privacies[i].Length - 1]))
                {
                    result = terms[j].Substring(2);
                    priResult = privacies[i].Remove(privacies[i].Length - 1);
                    DateTime priDateTime = DateTime.Parse(priResult);
                    
                    
                    if(now >= priDateTime.AddMonths(int.Parse(result)))
                    {
                        answer.Add(i + 1);
                    }
                }
            }
        }
        
        
        return answer.ToArray();
    }
}