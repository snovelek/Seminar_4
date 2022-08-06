// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число - ");
int n= Convert.ToInt32(Console.ReadLine());
int rez=0;
int n1=n;
while (n1>0) {
    rez=rez+n1%10;
    n1=n1/10;
}
Console.WriteLine(rez);