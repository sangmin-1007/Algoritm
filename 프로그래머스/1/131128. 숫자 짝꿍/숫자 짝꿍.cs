using System;
using System.Collections.Generic;
using System.Linq;
    
public class Solution {
    public string solution(string X, string Y) {
        List<char> answer = new List<char>();
        List<char> xList = X.ToList();
        List<char> yList = Y.ToList();
        
        xList.Sort();
        yList.Sort();
        
        int indexX = 0;
        int indexY = 0;
        
        while(indexX < xList.Count && indexY < yList.Count)
        {
            if(xList[indexX] == yList[indexY])
            {
                answer.Add(xList[indexX]);
                indexX++;
                indexY++;
            }
            else if(xList[indexX] != yList[indexY])
            {
                if(xList[indexX] > yList[indexY])
                {
                    indexY++;
                }
                else
                {
                    indexX++;
                }
            }
        }
        
        if(answer.Count == 0)
        {
            return "-1";
        }
        else if(answer[answer.Count() - 1] == '0')
        {
            return "0";
        }
        
        answer.Reverse();
        string str = new string(answer.ToArray());
        
        return str;
    }
}