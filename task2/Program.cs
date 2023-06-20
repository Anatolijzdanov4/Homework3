// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using System;

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
static void CheckQuater(int x1, int x2, int y1, int y2, int z1, int z2)
{
    {
        double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                             Math.Pow(y2 - y1, 2) +
                             Math.Pow(z2 - z1, 2) *
                                       1.0), 0.5);
        Console.WriteLine("Distance is \n" + d);
        return;
    }
}
int[] cordinates = new int[6];

cordinates[0] = ReadInt("Введите координату x1: ");

cordinates[1] = ReadInt("Введите координату x2: ");

cordinates[2] = ReadInt("Введите координату y1: ");

cordinates[3] = ReadInt("Введите координату y2: ");

cordinates[4] = ReadInt("Введите координату z1: ");

cordinates[5] = ReadInt("Введите координату z2: ");
CheckQuater(cordinates[0], cordinates[1], cordinates[2], cordinates[3], cordinates[4], cordinates[5]);
