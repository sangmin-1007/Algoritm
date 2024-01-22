using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        answer = new String(temp);
            
        return answer;
    }
}