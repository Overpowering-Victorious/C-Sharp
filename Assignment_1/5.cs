Console.WriteLine("Enter string: ");
string s=Console.ReadLine();
int alphabets = 0, digits = 0, special_char = 0;
for(int i=0; i<s.Length; i++)
{
    if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
        alphabets++;
    else if (s[i] >= '0' && s[i] <= '9')
        digits++;
    else
        special_char++;
}
Console.WriteLine("Number of alphabets: " + alphabets);
Console.WriteLine("Number of digits: " + digits);
Console.WriteLine("Number of special_char: " + special_char);
