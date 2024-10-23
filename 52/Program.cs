string source = Console.ReadLine();
string substring = Console.ReadLine();

var indices = new List<int>();

int index = source.IndexOf(substring, 0);
while (index > -1)
{
    Console.WriteLine(index);
    indices.Add(index);
    index = source.IndexOf(substring, index + substring.Length);
    
}