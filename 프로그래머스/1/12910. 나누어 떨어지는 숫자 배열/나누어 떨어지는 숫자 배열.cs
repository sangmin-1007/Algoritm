using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        List<int> list = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                list.Add(arr[i]);
            }
        }
        
        if(list.Count != 0)
        {
            list.Sort();
            answer = list.ToArray();
        }
        else
        {
            answer = new int[] {-1};
        }
        return answer;
    }
}