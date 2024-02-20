using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int mWidth = 0, mHeight = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            int width = Math.Max(sizes[i,0],sizes[i,1]);
            int height = Math.Min(sizes[i,0],sizes[i,1]);
            
            if(mWidth < width) mWidth = width;
            if(mHeight < height) mHeight = height;
            
        }
        
        return answer = mWidth * mHeight;
    }
}