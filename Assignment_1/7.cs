Console.WriteLine("Enter string: ");
string s=Console.ReadLine();
int vovels = 0, consonents = 0;
for(int i = 0; i<s.Length; i++)
{
    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
        vovels++;
    else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
        consonents++;
}

Console.WriteLine("Number of vovels: " + vovels);
Console.WriteLine("Number of consonents: " + consonents);