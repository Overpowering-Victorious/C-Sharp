Console.WriteLine("Enter the character: ");
char c = (char)Console.Read();

if (c >= 'a' && c <= 'z')
    Console.WriteLine("The character is lowercase");
else if (c >= 'A' && c <= 'Z')
    Console.WriteLine("The character is uppercase");