string[] StringToArrayConverter(string text)
{
    string[] outputArray = text.Split(' ');
    return outputArray;
}

void PrintToConsole(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"array[{i}] - {array[i]} \n");
    }
}

string PrintToFile(string[] array)
{
    string outputString = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        outputString += ($"array[{i}] - {array[i]} \n");
    }
    return outputString;
}

int ShortLineCounter(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }
    return count;
}

Console.Clear();

string textExample = "Мы должны убедиться что базовое знакомство с IT прошло успешно";
string[] inputArray = StringToArrayConverter(textExample);
Console.WriteLine("Input Array:");
Console.WriteLine();
PrintToConsole(inputArray);
Console.WriteLine();
string inputText = PrintToFile(inputArray);
for (int i = 0; i < inputArray.Length; i++) File.WriteAllText("input_data.txt", inputText);
int lineCounter = ShortLineCounter(inputArray);
