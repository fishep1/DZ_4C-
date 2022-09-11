// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число А: ");
int b = Convert.ToInt32(Console.ReadLine());

for(int i = b; i <= b; i++)
    Console.WriteLine($"{a}^{b} = {Math.Pow(a, b)}");

