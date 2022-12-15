// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[].
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int a = 99;
int b = 1000;
int c = 10;
int result1;

if (number < a)
{
    Console.WriteLine($"Вы ввели число {number}");
    Console.WriteLine($"Число {number} не является трехзначным");
}
else

if (number < b)
{
    Console.WriteLine($"Вы ввели число {number}, являющееся трехзначным числом");
    result1 = number % c;
    Console.WriteLine($"Третья цифра числа {number} равна {result1}");
}
else

if (number > b)
{
    Console.WriteLine($"Вы ввели число {number}");
    Console.Write($"Число {number} преобразовано в трехзначаное число ");
    for(; number > b; number /= c)
    {
        result1 = number;
    }
    Console.WriteLine(number);
    int result2 = number % c;
    Console.WriteLine($"Третье число числа {number} равно {result2}");
}