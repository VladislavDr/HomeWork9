// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число, чтобы проверить является ли оно палиндромом");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 9999 || n > 99999) {
    Console.WriteLine("Нужно пятизначное число. Попробуй еще раз");
}
else {bool isPalindrom (int source){
        int originalCopy = source;
        int reverseNumber = 0;
        while ( source > 0) {
            int remainder = source % 10;
            reverseNumber = (reverseNumber * 10) + remainder;
            source /= 10;
        }
        return originalCopy == reverseNumber;
    } 
    if (isPalindrom(n)){
        Console.WriteLine("Палиндром");}
        else {
            Console.WriteLine("Не палиндром");
        }
}
