using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int prime = 0;
        
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                for(int k = j+1; k < nums.Length; k++)
                {
                    prime = nums[i] + nums[j] + nums[k];
                    
                    for(int n = 2; n < prime; n++)
                    {
                        if(prime % n == 0)
                            break;
                        else if(n == prime - 1)
                        {
                            answer++;
                        }
                    }
                }
            }
        }

        return answer;
    }
}