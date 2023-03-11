// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9


int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int IsAckermannFunction(int m, int n){
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return IsAckermannFunction(m - 1, 1);
    if(m > 0 && n > 0) return IsAckermannFunction(m - 1, IsAckermannFunction(m, n - 1));
    return 0;
}

int M = IsReadNumber("Введите положительное значение M");
int N = IsReadNumber("Введите положительное значение N");
while ( M < 0 || N < 0){
    Console.WriteLine();
    Console.WriteLine("Внимание! Вы ввели отрицательное число!");
    Console.WriteLine("Попробуй снова!");
    Console.WriteLine();
    M = IsReadNumber("Введите положительное значение M");
    N = IsReadNumber("Введите положительное значение N");
}
Console.WriteLine(IsAckermannFunction(M, N));