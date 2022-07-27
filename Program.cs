string[] StringToArrayConverter(string text)
{
    string[] outputArray = text.Split(' ');
    return outputArray;
}

void PrintToConsole(string[] array, string text)
{
    Console.WriteLine(text);
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"array[{i}] - {array[i]} \n");
    }
    Console.WriteLine();
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

string[] ShortStringArrayCreator(string[] inputArray, int arrayLength)
{
    int index = 0;
    string[] outputArray = new string[arrayLength];
    for (int i = 0; i <= inputArray.Length - 1; i++)
    {
        if (inputArray[i].Length < 4)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
    }
    return outputArray;
}

Console.Clear();

string textExample = "Мы должны убедиться что базовое знакомство с IT прошло успешно";
string[] inputArray = StringToArrayConverter(textExample);
PrintToConsole(inputArray, "Input Array:");
string inputText = PrintToFile(inputArray);
File.WriteAllText("input_data.txt", inputText);

int lineCounter = ShortLineCounter(inputArray);
string[] outputArray = ShortStringArrayCreator(inputArray, lineCounter);
PrintToConsole(outputArray, "Output Array:");
string outputText = PrintToFile(outputArray);
File.WriteAllText("output_data.txt", outputText);