using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string temp = n.ToString();
        int[] answer = new int[temp.Length];
        string newTemp = new string(temp.Reverse().ToArray());
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] += (int)Char.GetNumericValue(newTemp, i);
        }
        return answer;
    }
}