// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int IsSumMToN(int m, int n){
    //int sum = 0;
    if(m > n) return 0;
    return m + IsSumMToN(m + 1, n);
}

int M = IsReadNumber("Введите значение M");
int N = IsReadNumber("Введите значение N");
Console.WriteLine(IsSumMToN(M, N));