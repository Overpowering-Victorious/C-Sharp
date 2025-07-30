//https://leetcode.com/problems/valid-palindrome/description/?envType=study-plan-v2&envId=top-interview-150

public class Solution {
    public bool IsPalindrome(string s) {
        string st="",tmp="";
        int n=s.Length;
        for(int i=0; i<n; i++)
        {
            if((s[i]>='a' && s[i]<='z') || (s[i]>='0' && s[i]<='9'))
                tmp+=s[i];
            else if(s[i]>='A' && s[i]<='Z')
                tmp+=(char)('a'+(s[i]-'A'));
        }
        n=tmp.Length;
        for(int i=0; i<n/2; i++)
        {
            if(tmp[i]!=tmp[n-i-1])
                return false;
        }
        return true;
    }
}
