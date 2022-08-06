// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число:");
int n= Convert.ToInt32(Console.ReadLine());

if (n>0 && n<10){
    Console.WriteLine("1");
}
if (n>9 && n<100){
    Console.WriteLine("2");
}
if (n>99 && n<1000){
    Console.WriteLine("3");
}
if (n>999 && n<10000){
    Console.WriteLine("4");
}
if (n>9999 && n<100000){
    Console.WriteLine("5");
}
if (n>99999 && n<1000000){
    Console.WriteLine("6");
}
if (n>999999){
    Console.WriteLine("7");
}
