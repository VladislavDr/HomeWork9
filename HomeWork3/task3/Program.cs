// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число, чтобы увидеть таблицу кубов от 1 до Вашего числа");
double n = Convert.ToInt32(Console.ReadLine());
double a = 1;

for (double i = 1; i <= n; i++) {
    a = Math.Pow(i, 3);
    Console.WriteLine(a);
}
