// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] IsCreatMatrix(int rows, int colomns){
    int[,] matrix = new int[rows, colomns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix [i,j] = Random.Shared.Next(0,10);
        }
    }
    return matrix;
}

void IsPrintMatrix(int [,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write(matrix [i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] IsMatrixMultiplication(int [,] matrix1, int [,] matrix2){
    int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix [i,j] = matrix1[i,j] * matrix2[i,j];
            Console.Write(matrix [i,j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}


int rowsMatrix = IsReadNumber("Введите количество строк");
int colomnsMatrix = IsReadNumber("Введите количество столбцов");
int [,] myMatrix1 = IsCreatMatrix(rowsMatrix, colomnsMatrix);
int [,] myMatrix2 = IsCreatMatrix(rowsMatrix, colomnsMatrix);
Console.WriteLine("Первая матрица");
IsPrintMatrix(myMatrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
IsPrintMatrix(myMatrix2);
Console.WriteLine();
Console.WriteLine("Проивездение двух матриц");
IsMatrixMultiplication(myMatrix1, myMatrix2);