﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число:");

int n= Convert.ToInt32(Console.ReadLine());
int pr=1;
Console.WriteLine(n);
for (int i=1;i<=n;i++){
    pr=pr*i;
}
Console.WriteLine(pr);