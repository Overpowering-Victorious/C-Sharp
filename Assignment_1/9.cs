Console.WriteLine("Enter the string: ");
string s=Console.ReadLine();
Console.WriteLine("Enter the start position: ");
string st=Console.ReadLine();
Console.WriteLine("Enter the length: ");
string len = Console.ReadLine();
string tmp = "";

int start=int.Parse(st), length=int.Parse(len);
for(int i=start; i<start+length; i++)
{
    tmp += s[i];
}

Console.WriteLine("Retrieved string: "+tmp);