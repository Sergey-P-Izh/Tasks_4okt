// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите цело число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 999)
{
    do
{
    Console.WriteLine(number);
    number = number /10 ;
}
while (number /1000 > 0); 
}
int lastDigit = number %10;
Console.WriteLine($"Третья цифра числа {lastDigit}");
else Console.WriteLine("Нет третьей цифры");


    

