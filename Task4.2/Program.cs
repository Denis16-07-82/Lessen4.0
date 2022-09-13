// Задача 2: Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
ulong Prompt(string messege)
{
    System.Console.WriteLine(messege);
    ulong velue = Convert.ToUInt64(Console.ReadLine());
    return velue;
}
ulong velueA = Prompt("Введит число : ");

ulong sumdigits(ulong velue)
{
    ulong summ = 0;
    while (velue > 0)
    {
        summ += velue % 10;
        velue = (velue) / 10;
    }
    return summ;
}
ulong Summ = sumdigits(velueA);
System.Console.WriteLine($"Сумма цифр числа {velueA} -> {Summ}");