string[] arr1 = { "hello", "a", "word", ":-)" };

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] newarr = new string[arr1.Length];
int j = 0;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= 3)
    {
        newarr[j] = arr1[i];
        j++;
    }
}

Print(newarr);