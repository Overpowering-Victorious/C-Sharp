string s=Console.ReadLine();
int n = s.Length;
string s1 = "";
for(int i = 0; i < n; i++)
{
    char c = s[i];
    if(s[i]>='A' &&  s[i]<'Z')
        c = (char)('a' + (s[i]-'A'));
    else if(s[i] >= 'a' && s[i] < 'z')
        c = (char)('A' + (s[i] - 'a'));
    s1 += c;
}

Console.WriteLine(s1);