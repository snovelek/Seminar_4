﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] n = new int[8];
Random rnd = new Random();
for (int i=0;i<8;i++){
    n[i]=rnd.Next(0,2);
    Console.Write($"{n[i]},");
}

Console.WriteLine(string.Join(", ", n));