void func(string[] arr, string[] newArr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
}

Console.Clear();
Console.WriteLine("Введите значения элементов массива, через запятую:");
string[] arr = Console.ReadLine().Split(",");
string[] newArr = new string[arr.Length];
func(arr, newArr);
Array.Resize(ref newArr, newArr.Count(x => x != null));

Console.WriteLine($"Исходный массив:\n[{string.Join(", ", arr)}]");
Console.WriteLine($"Новый массив:\n[{string.Join(", ", newArr)}]");
