Console.WriteLine("Enter string: ");
string s=Console.ReadLine();
Console.WriteLine("Characters of string: ");
for(int i=s.Length-1; i>=0; i--)
{
    Console.Write(s[i]);
}
