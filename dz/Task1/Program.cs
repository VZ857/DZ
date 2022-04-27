// Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.Write("Введите певрое число");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Первое число больше");

}
else
{
    Console.WriteLine("Второе число больше");
}

