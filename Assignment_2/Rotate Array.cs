//https://leetcode.com/problems/rotate-array/description/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public void Rotate(int[] v, int k) {
        int n=v.Length;
        k = (k % n);
        int[] u = new int[n];
        for(int i=0; i<n; i++)
        {
            u[(i+k)%n]=v[i];
        }
        for(int i=0; i<n; i++)
        {
            v[i]=u[i];
        }
    }
}
