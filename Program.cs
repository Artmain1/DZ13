/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]*/

Console.Write("Введи размер массива ");
int i = Convert.ToInt32(Console.ReadLine());
int[] num = new int[i];

for (int n = 0; n < i; n++ )
{
    num[n] = new Random().Next(0, 20);
    Console.WriteLine(num[n]);
}
