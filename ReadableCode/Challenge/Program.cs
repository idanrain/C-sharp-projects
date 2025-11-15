string str = "the quick brown fox jumps over the lazy dog";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int X = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        X++;
    }
}

string new_message = new string(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {X} times");

