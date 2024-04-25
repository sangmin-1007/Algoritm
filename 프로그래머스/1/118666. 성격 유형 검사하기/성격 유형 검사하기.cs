using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        Dictionary<char, int> score = new Dictionary<char, int>()
        {
            {'R',0 },{'T',0 },{'C',0 },{'F',0 },{'J',0 },{'M',0 },{'A',0 },{'N',0 },
        };
        Dictionary<int, int> addScore = new Dictionary<int, int>()
        {
            { 1,3 },{ 2,2 },{ 3,1 },{ 4,0 },{ 5,-1 },{ 6,-2 },{ 7,-3 }
        };
        
        for(int i = 0; i < survey.Length; i++)
        {
            score[survey[i][0]] += addScore[choices[i]];
        }
        
        if (score['R'] >= score['T'])
        {
            answer += "R";
        }
        else
        {
            answer += "T";
        } 

        if (score['C'] >= score['F'])
        {
            answer += "C";
        }
        else
        {
            answer += "F";
        }

        if (score['J'] >= score['M'])
        {
            answer += "J";
        }
        else
        {
            answer += "M";
        }

        if (score['A'] >= score['N'])
        {
            answer += "A";
        }
        else
        {
            answer += "N";
        }
        
        return answer;
    }
}