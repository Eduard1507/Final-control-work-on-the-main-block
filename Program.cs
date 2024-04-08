string[] FilterStrings(string[] array)
{
    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
    string[] filteredArray = new string[count];
    int index = 0;

    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            filteredArray[index] = str;
            index++;
        }
    }

    return filteredArray;
}
{
    string[] inputArray = { "apple", "banana", "cat", "dog", "elephant" };
    string[] filteredArray = FilterStrings(inputArray);
    Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
    foreach (string str in filteredArray)
    {
        Console.WriteLine(str);
    }
}
