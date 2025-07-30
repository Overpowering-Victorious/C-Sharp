Console.WriteLine("Enter string: ");
string s1=Console.ReadLine();
string s2 = Console.ReadLine();
bool p = true;
if(s1.Length!=s2.Length) p = false;
else
{
    for(int i=0; i<s1.Length; i++)
    {
        if (s1[i] != s2[i])
        {
            p = false;
            break;
        }
    }
}
if (p)
    Console.WriteLine("The string are of same length and equal");
else
    Console.WriteLine("String are not equal");
