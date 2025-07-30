Console.WriteLine("Enter the string: ");
string s1 = Console.ReadLine();
Console.WriteLine("Enter string to be searched: ");
string s2 = Console.ReadLine();
Console.WriteLine("Enter string to be inserted: ");
string s3 = Console.ReadLine();

string s4 = "";

int c = 0,i=0,j=0;
for (; i < s1.Length; i++)
{
    j = 0;
    for (; j < s2.Length; j++)
    {
        if (s1[i + j] != s2[j])
            break;
    }
    if (j == s2.Length)
    {
        s4 += (s3+' ');
        break;
    }
    else
        s4 += s1[i];
}
while(i<s1.Length) s4 += s1[i++];

Console.WriteLine("Modified string: " + s4);