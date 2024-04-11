using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int count = 0;
        int result = 0;
        
        for(int i = 0; i < targets.Length; i++)
        {
            for(int j = 0; j < targets[i].Length; j++)
            {
                count = Keyboard(keymap,targets[i][j]);
                
                if(count == -1)
                {
                    result = -1;
                    break;
                }
                result += count;
            }
            answer[i] = result;
            result = 0;
        }
        return answer;
    }
    
    public int Keyboard(string[] keymap, char target)
    {
        int count = -1;
        
        for(int i = 0; i < keymap.Length; i++)
        {
            for(int j = 0; j < keymap[i].Length; j++)
            {
                if(keymap[i][j] == target)
                {
                    if(count == -1) count = j + 1;
                    else if(count > j) count = j + 1;
                    break;
                }
            }
        }
        return count;
    }
}