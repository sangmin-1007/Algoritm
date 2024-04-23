using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ingredList = new List<int>();
        
        foreach(int item in ingredient)
        {
            ingredList.Add(item);
            
            if(ingredList.Count >= 4)
            {
                if(ingredList[ingredList.Count-4] == 1 && ingredList[ingredList.Count-3] == 2 &&
                  ingredList[ingredList.Count-2] == 3 && ingredList[ingredList.Count-1] == 1)
                {
                    answer++;
                    ingredList.RemoveRange(ingredList.Count-4,4);
                }
            }
        }
        return answer;
    }
}