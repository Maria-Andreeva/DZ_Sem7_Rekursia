// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

void PrintArray (int[] myArray, int i)
{

    if(i >= 0)
    {
        Console.Write(myArray[i] + " ");
        PrintArray(myArray, --i);
    }
}

int[] myArray = {1, 2, 3, 4, 5};
PrintArray(myArray, myArray.Length - 1);