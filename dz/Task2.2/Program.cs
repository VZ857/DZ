// Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.


Console.WriteLine("Введите число");
    while(true)
    {
int num1 = Convert.ToInt32(Console.ReadLine());  
string num1Text = Convert.ToString(num1);    
 if (num1Text.Length > 2)
            Console.WriteLine("третья цифра - " + num1Text[2]);
        else
            Console.WriteLine("третьей цифры нет");
    }

