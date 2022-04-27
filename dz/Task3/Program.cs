// Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.Write("Введите число");
int num1 = int.Parse(Console.ReadLine());
if (num1 % 2 == 0)
{
   Console.WriteLine("Четное число");
}
else
{
   Console.WriteLine("Нечетное число");
   
}