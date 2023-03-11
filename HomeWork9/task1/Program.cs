// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int valeu = Convert.ToInt32(Console.ReadLine());
    return valeu;
}

string Function(int n){
    string x;
    if(n > 0) {
        x = n + " " + Function(n - 1);
        return x;
    }    
    return "";
}
int num = IsReadNumber("Введите числе N");
Console.WriteLine($"{Function(num)}");