// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//(номер цифры считается от левого края)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6 

Console.WriteLine("Введите целое число");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
int result = 0;

if (number < 100){
    Console.WriteLine("Третьей цифры нет");
}

while (number >= 1000){
        number = number / 10;
    }
    result = number % 10;
Console.WriteLine(result);