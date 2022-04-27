//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите певрое число");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите певрое число");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Первое число больше");

}
else if (num2 >num3)

{
        Console.WriteLine("Второе число больше");

}
else 
{
        Console.WriteLine("Третье число больше");
}

