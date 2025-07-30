Console.WriteLine("Enter the numbers in a line: ");
string s=Console.ReadLine();
int mx = (int)-1e9, mn = (int)1e9,x;
string tmp = "";
for(int i = 0; i < s.Length; i++)
{
    if (s[i] == ' ')
    {
        x = int.Parse(tmp);
        tmp = "";
        mx = Math.Max(mx, x);
        mn = Math.Min(mn, x);
    }
    else
        tmp += s[i];
}
x = int.Parse(tmp);
mx = Math.Max(mx, x);
mn = Math.Min(mn, x);

Console.WriteLine("The max and min numbers in the string: " + mx + " " + mn);