// Задача 3: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

double[] arrayA = new double[8];
for(int i = 0;i < 8;i++)
{
    Console.WriteLine($"Введите {i + 1} ый элемент массива");
    arrayA[i] = Convert.ToDouble(Console.ReadLine());
}
System.Console.Write("полученный массив : [");
for(int i = 0;i < 7;i++)
{
    System.Console.Write($"{arrayA[i]}, ");
}
System.Console.Write($"{arrayA[7]} ]");
System.Console.WriteLine();