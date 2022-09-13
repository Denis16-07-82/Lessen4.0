// Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран. Также ищет второй максимум (число меньше максимального элемента,
//но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7

int[] arrayA = new int[8];
for (int i = 0; i < 8; i++)
{
    arrayA[i] = new Random().Next(0, 20);
    Console.Write($"{arrayA[i]} ");
}
for (int j = 0; j < 8; j++)
{
    for (int i = j; i < 8; i++)
    {
        int max = arrayA[j];
        if (arrayA[i] > max)
        {
            max = arrayA[i];
            arrayA[i] = arrayA[j];
            arrayA[j] = max;
        }

    }
}
for (int i = 1; i < 8; i++)
{
    if (arrayA[i] < arrayA[0])
    {
        Console.Write($"->{arrayA[i]} ");
        break;
    }
}
System.Console.WriteLine();

