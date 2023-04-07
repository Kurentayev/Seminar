// 1. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
int result = (numA * numA);
if(result == numB)
{
    Console.WriteLine("numA квадрат numB");
}
else 
{
    Console.WriteLine("numA не квадрат numB");
}
