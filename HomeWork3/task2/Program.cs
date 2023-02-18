// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//d = √(x2-x1)2 + (y2-y1)2 + (z2 - z1)2


double ReadNumber (string messageToUser){
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber ("Введите координату А по оси х");
double xb = ReadNumber ("Введите координату В по оси х");
double xc = ReadNumber ("Введите координату С по оси х");
double ya = ReadNumber ("Введите координату А по оси у");
double yb = ReadNumber ("Введите координату В по оси у");
double yc = ReadNumber ("Введите координату С по оси у");

double d = Math.Sqrt(Math.Pow(ya - xa, 2) + Math.Pow(yb-xb, 2) + Math.Pow(yc - xc, 2)); 
Console.WriteLine(d);