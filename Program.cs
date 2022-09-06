//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] Array;
Array = new int[4];
Random rand = new Random();
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rand.Next(100, 1000);
    if (Array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", Array));
Console.WriteLine(count);