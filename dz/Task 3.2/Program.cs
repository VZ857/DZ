 //Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine("Введите цыфру дня недели ");
    while(true)
    {
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 | day == 7) {

     Console.WriteLine("Это выходной день ");
    }
else if (day <1 | day > 7) {       
     Console.WriteLine(" такого дня нет");
}
    else Console.WriteLine("Это рабочий день ");

    }
