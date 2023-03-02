// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

(double, double) FindingSolution(double b1, double k1, double b2, double k2){
    double x1 = (b2 - b1) / (k1 - k2);
    double y1 = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (x1, y1);
}

double b1 = IsReadNumber("Введите координату b1 ");
double k1 = IsReadNumber("Введите координату k1 ");
double b2 = IsReadNumber("Введите координату b2 ");
double k2 = IsReadNumber("Введите координату k2 ");
(double x1, double y1) = FindingSolution(b1, k1, b2, k2);
Console.WriteLine($"({x1};{y1})");