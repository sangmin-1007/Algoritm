using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        int j, k, n;
        
        for(int i= 0; i < commands.GetLength(0); i++)
        {
            j = commands[i,0];
            k = commands[i,1];
            n = commands[i,2];
            
            int[] temp = new int[k-j+1];
            
            for(int a = 0; a < temp.Length; a++)
            {
                temp[a] = array[a+j-1];
            }
            Array.Sort(temp);
            
            answer[i] = temp[n-1];
        }
        
        return answer;
    }
}