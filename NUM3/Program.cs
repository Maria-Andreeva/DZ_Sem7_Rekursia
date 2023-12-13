// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Console.Clear();

int[] PrintArray (int[] myArray)
{
    if(myArray.Length > 0)
    {
        Console.Write(myArray[myArray.Length - 1] + " ");

        var temparray = myArray.ToList();
        temparray.RemoveAt(myArray.Length - 1);

        return PrintArray(temparray.ToArray());
    }

    return null!;
    
}

int[] myArray = {1, 2, 3, 4, 5};
PrintArray(myArray);


