// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int[] number = new int[5];
System.Console.WriteLine("Введите число");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int i = 0;
while (i < 5)
    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
    {
        System.Console.WriteLine("Являеться полиндромом");

    }
    else
    {
        System.Console.WriteLine("Число не являеться полиндромом");
        i++;
    }