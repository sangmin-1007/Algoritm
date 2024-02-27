using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] charTemp = s.ToCharArray();
        int index;
        
        for(int i = 0; i < charTemp.Length; i++)
        {
            if(charTemp[i] == ' ') continue;
            
            index = (int)charTemp[i] + n;       
            
            if(charTemp[i] >= 'A' && charTemp[i] <= 'Z')
            {
                if(index > 'Z')
                {
                    index -= 26;
                }
            }
            else
            {
                if(index > 'z')
                {
                    index -= 26;
                }
            }
           
            charTemp[i] = Convert.ToChar(index);
        }
        answer = new string(charTemp);
        return answer;
    }
}