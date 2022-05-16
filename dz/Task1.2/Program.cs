
//Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.WriteLine("Введите трехзначное число");
    while(true)
    {
        int num1 = int.Parse(Console.ReadLine());
        if(num1 > 99)
            Console.WriteLine((num1/ 10) % 10);
        else
            break;
    }