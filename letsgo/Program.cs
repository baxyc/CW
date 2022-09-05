string[] resultArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i].Length < 4)
        {
            size++; 
        }
    }
    string[] newArray = new string[size]; 
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArray[index] = arr[i];
            index++;
        }
    }
    return newArray;
}

string[] array = { "123", "ABC", "RUS", "ENG", "GG", "WP" };
string[] array1 = { "987", "АБВ", "Sister", "Brother", "Mom", "Dad" };

Console.WriteLine(String.Join(", ", resultArray(array)));
Console.WriteLine(String.Join(", ", resultArray(array1)));