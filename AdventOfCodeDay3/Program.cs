string[] lines = System.IO.File.ReadAllLines(@"C:\Users\chris\source\repos\AdventOfCodeDay3\AdventOfCodeDay3\TextFile1.txt");
int total = 0;
var badgeTotal = 0;
string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//part 1
foreach (string line in lines)
{
    var index = (line.Length / 2) - 1;
    var str1 = line.Substring(0, index) + line[index];
    var str2 = line.Substring(index + 1);
    foreach (char letter in str1)
    {
        if (str2.Contains(letter))
        {
            total+= alpha.IndexOf(letter)+1;
            break;
        }
    }
}
//Console.WriteLine(total);
//part 2
for (int i = 0; i < lines.Length; i += 3)
{
    foreach (char letter in lines[i])
    {
        if (lines[i + 1].Contains(letter) && lines[i + 2].Contains(letter))
        {
            badgeTotal+= alpha.IndexOf(letter)+1;
            break;
        }
    }
}
Console.WriteLine(badgeTotal);
