using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "";
        int cards1Index = 0;
        int cards2Index = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(cards1Index < cards1.Length && goal[i] == cards1[cards1Index])
            {
                cards1Index++;
                answer = "Yes";
            }
            else if(cards2Index < cards2.Length && goal[i] == cards2[cards2Index])
            {
                cards2Index++;
                answer = "Yes";
            }
            else
            {
                answer = "No";
                return answer;
            }
        }
        
        return answer;
    }
}