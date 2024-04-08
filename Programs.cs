string[] FilterStrings(string[] array)

    int count = 0;
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
