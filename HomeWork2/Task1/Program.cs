// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Введите трехзначное число");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int sumA = 0;
int sum = 0;

if(number > 99 && number < 10000) {
    sumA = number / 10;
    sum = sumA % 10;
    Console.WriteLine(sum);
}