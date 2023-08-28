//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:");

int number = Convert.ToInt32(Console.ReadLine());

int a = (number - number % 10000) / 10000;
int b = (number - number % 1000 - (number - number % 10000)) / 1000;
int c = (number - number % 100 - (number - number % 1000)) / 100;
int d = (number - number % 10 - (number - number % 100)) / 10;
int f = number - (number - number % 10);

if (a == f && b == d) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");