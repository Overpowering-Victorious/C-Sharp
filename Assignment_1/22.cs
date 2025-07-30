Console.WriteLine("Enter the numbers in a line: ");
string s=Console.ReadLine();
int n = s.Length;
bool p = false;
string st = "";
if (s[0] >= 'a' && s[0] <= 'z') p = true;
for(int i=0; i<n; i++)
{
    if (s[i] == ' ')
        p = true;
    if (p && s[i] >= 'a' && s[i] <= 'z')
    {
        st += (char)('A' + (s[i] - 'a'));
        p = false;
    }
    else
        st += s[i];
}

Console.WriteLine("Modified String: "+st);