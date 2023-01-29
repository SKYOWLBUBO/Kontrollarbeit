string[] arr = PutArray();
string[] res = FindArray(arr, 3);

string[] PutArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] FindArray(string[] input, int c)
{
    string[] output = new string[CountArray(input, c)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= c)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}
int CountArray(string[] input, int c)
{
     int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= c) {
            count++;
        }
    }

    return count;
}

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ", res)}]");