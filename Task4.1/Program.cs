// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

ulong Prompt(string messege)
{
  System.Console.WriteLine(messege);
  ulong velue = Convert.ToUInt64(Console.ReadLine());
  return velue;
}
ulong velueA = Prompt("Введите число A : ");
ulong velueB = Prompt("Введите число B : ");
ulong velueC = 1;
for(ulong i = 0;i < velueB;i++)
{
    velueC = velueC*velueA;
}
System.Console.WriteLine($"{velueA} , {velueB} -> {velueC}");