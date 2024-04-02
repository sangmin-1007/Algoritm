using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int temp = 0;
        int zero = 0;
        
        for(int i = 0; i < win_nums.Length; i++)
        {
            if(lottos[i] == 0)
                zero++;
            
            if(win_nums.Contains(lottos[i]))
            {
                temp++;
            }
        }
        
        answer[0] = Rank(temp + zero);
        answer[1] = Rank(temp);
        return answer;
        
    }
    
    public int Rank(int temp)
    {
        switch(temp)
        {
            case 6:
                return 1;
            case 5:
                return 2;
            case 4:
                return 3;
            case 3:
                return 4;
            case 2:
                return 5;
            default:
                return 6;
        }
    }
}