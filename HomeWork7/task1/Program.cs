// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​// m = 3, n = 4. ​
// 0,5 7 -2 -0,2 ​
// 1 -3,3 8 -9,9 ​
// 8 7,8 -7,1 9

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double [,] GetRandomMatrix (int rows, int colomns){
    double[,] matrix = new double [rows, colomns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = Random.Shared.NextDouble() * 10000 - 50;
        }
    }
    return matrix;
}

void IsPrintMatrix(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(" {0,5:F2} ", matrix[i,j]);
        }
        Console.WriteLine();
    }
}
int m = IsReadNumber("Введите количество строк");
int n = IsReadNumber("Введите количество столбцов");
double [,] myMatrix = GetRandomMatrix(m, n);
IsPrintMatrix(myMatrix);