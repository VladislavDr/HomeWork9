// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[,] IsCreatMatrix(int rows, int colomns){
    int[,] matrix = new int[rows, colomns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = Random.Shared.Next(0, 10);
        }
    }
    return matrix;
}

void IsPrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] IsAVG(int[,] matrix, int m, int n){
    double sum = 0;
    double avg = 0;
    double[] array = new double [n];
    for(int j = 0; j < n; j++){
        avg = 0;
        sum = 0;
        for(int i = 0; i < m; i++){
            sum += matrix[i,j];
        }
        avg = sum / m;
        avg = Math.Round(avg, 2);
        array[j] = avg;
    }
    return array;
}

int m = IsReadNumber("Введите количество строк");
int n = IsReadNumber("Введите количество столбцов");
int[,] myMatrix = IsCreatMatrix(m, n);
IsPrintMatrix(myMatrix);

double[] res = IsAVG(myMatrix, m, n);
Console.WriteLine($"Среднее арифметическое каждого столбца:[{string.Join("; ", res)}]");


