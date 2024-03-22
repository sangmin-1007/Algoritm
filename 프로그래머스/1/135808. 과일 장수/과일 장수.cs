using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int box = score.Length / m;
        
        Array.Sort(score);
        Array.Reverse(score);
        
        int index = m - 1;
        
        for(int i =0; i < box; i++)
        {
            answer += score[index] * m;
            index += m;
        }
        
        
        return answer;
    }
}