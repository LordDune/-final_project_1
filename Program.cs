string? arrayString = ReadString("Введите элементы массива через пробел: "); // Hello 2 World :-)
string[]? array = StringToArray(arrayString, ' ');
ShowAray(array, "Исходный массив: "); // Исходный массив:  [Hello, 2, World, :-)]
string[]? arrayNew = CreateNewArrayNoMoreThanLen(array, 3);
ShowAray(arrayNew, "Результирующий массив: "); // Результирующий массив:  [2, :-)]

string? ReadString(string? text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}

string[] StringToArray(string text, char separator)
{
    return text.Split(separator).ToArray();
}

void ShowAray(string[] array, string text){
    Console.Write($"{text} [");
    int i = 0;
    for (; i < array.Length-1; i++) 
        Console.Write(array[i] + ", ");
    Console.WriteLine($"{array[i]}]");

}

string[] CreateNewArrayNoMoreThanLen(string[] array, int len){
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
        if (array[i].Length <= len) 
            count ++; string[]? result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= len) 
            result[count++] = array[i];
    return result;
}