
public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long temp;
        for(int i = 0; i < t.Length - p.Length + 1; i++)
        {
            temp = long.Parse(t.Substring(i,p.Length));
            if(temp <= long.Parse(p))
            {
                answer++;
            }
        }
        return answer;
    }
}