Console.WriteLine("Enter the string: ");
string s = Console.ReadLine();

int n = s.Length;
int[] a = new int[26];
for (int i = 0; i < n; i++)
{
    a[s[i] - 'a'] = 1;
}
string ans = "";
for(int i = 0;i < n; i++)
{
    if (a[s[i]-'a']>0)
    {
        ans += s[i];
        a[s[i] - 'a'] = 0;
    }
}
Console.WriteLine("The modified string: "+ans);