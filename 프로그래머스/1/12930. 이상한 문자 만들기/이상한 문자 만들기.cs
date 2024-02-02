using System;
public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] temps = s.Split(' ');
        for(int i = 0; i < temps.Length; i++)
        {
            for(int j = 0; j < temps[i].Length; j++)
            {
                if(j%2==0)
                {
                    answer += Char.ToUpper(temps[i][j]);
                }
                else
                {
                    answer += Char.ToLower(temps[i][j]);
                }
            }
            if(i != temps.Length - 1) answer += " ";
        }
        return answer;
    }
}