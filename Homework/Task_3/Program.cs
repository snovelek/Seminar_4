//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))


Console.Write("Введите число - ");
int [] n=new int[8];
for (int i=0;i<8;i++){
    n[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(String.Join(",",n));