//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] GetArray(int size, int min, int max)
{
    int[] myArray;
    myArray = new int[4];
    Random rand = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rand.Next(min, max);
    }

    return myArray;
}

void PrintArray(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res = array[i] + res;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");
}

int[] myArray = GetArray(8, -10, 10);
Console.WriteLine(string.Join(", ", myArray));
PrintArray(myArray);