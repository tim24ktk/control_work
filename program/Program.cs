string[] strings = AskArray();
string[] result = FillArray(strings, 3);

Console.WriteLine();
Console.WriteLine("Заданный и полученный массивы");
Console.WriteLine($"[{string.Join(", ", strings)}] -> [{string.Join(", ", result)}]");

string[] FillArray(string[] input, int n)
{
    string[] output = new string[CountLessThen(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThen(string[] input, int n)
{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }

    }
    return count;
}

string[] AskArray()
{
    Console.WriteLine("Введите элементы через пробел!");
    string inputStr = Console.ReadLine() ?? "";

    return inputStr.Split(" ");
}