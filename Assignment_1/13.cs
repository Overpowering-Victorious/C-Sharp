Console.WriteLine("Enter the string: ");
string s1 = Console.ReadLine();
Console.WriteLine("Enter the substring: ");
string s2 = Console.ReadLine();

int c = 0;
for (int i = 0; i < s1.Length; i++)
{
    int j = 0;
    for (; j < s2.Length; j++)
    {
        if (s1[i + j] != s2[j])
            break;
    }
    if (j == s2.Length)
        c++;
}

Console.WriteLine("The substring appears " + c + " times.");