void SecondArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
Console.Clear();
string[] array1 = new string[] {"1234", "1567","-2"};
string[] array2 = new string[array1.Length];
SecondArr(array1, array2);
PrintArr(array2);