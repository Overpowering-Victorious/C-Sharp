using System.Text;

static string bubble_sort(string s)
{
    int n=s.Length;
    StringBuilder st = new StringBuilder(s);
    for (int i=0; i<n; i++)
    {
        for(int j=n-1; j>i; j--)
        {
            if (st[i] > st[j])
            {
                char c=st[j];
                st[j] = st[i];
                st[i] = c;
            }
        }
    }
    return st.ToString();
}

Console.WriteLine("Enter number of strings");
string num=Console.ReadLine();
int n=int.Parse(num);
string[] v=new string[n];
for(int i=0; i<n; i++)
{
    v[i]=Console.ReadLine();
}

Console.WriteLine("After sorting: ");

for(int i=0; i<n; i++)
{
    string s = bubble_sort(v[i]);
    Console.WriteLine(s);
}