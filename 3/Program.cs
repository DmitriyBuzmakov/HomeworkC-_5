//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
double[] mass = new double[5];      
Random rand = new Random();      
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(-100, 100); 
    Console.Write($" {mass[i]} ");
}
double min = 0;
double max = 0;
foreach (double i in mass) 
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");