//https://leetcode.com/problems/median-of-two-sorted-arrays/description/

public class Solution {
    public double FindMedianSortedArrays(int[] v1, int[] v2) {
        int n = v1.Length, m = v2.Length;
        double med = 0;
        int i = n - 1, j = 0;
        while( i >= 0 && j < m)
        {
            if( v1[i] > v2[j])
            {
                int x = v2[j];
                v2[j] = v1[i];
                v1[i] = x;
            }
            i--;
            j++;
        }
        Array.Sort(v1);
        Array.Sort(v2);
        int mid = (n + m) / 2;
        if(((n+m)&1)==1)
        {
            if (mid < n)
                med=v1[mid];
            else
                med=v2[mid-n];
        }
        else
        {
            if (mid < n)
                med=(v1[mid-1] + v1[mid]) / 2.0;
            else if(mid==n)
                med=(v1[mid-1] + v2[0])/2.0;
            else
                med=(v2[mid-n-1] + v2[mid - n]) / 2.0;
        }
        return med;
    }
}
