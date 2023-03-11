// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumNum(int[,] matrix){
    int[] array = new int[matrix.GetLength(0)];
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(i <= j){
                sum += matrix[i,j];
            }
            array[i] = sum;
        }
        sum = 0;
    }
    return array;
}

int IsCheckForMin(int [] array){
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length - 1; i++){
        if(array[i] > array[i + 1]) {
            min = array[i + 1];
            index = i + 2;
        }
    }
    return index;
}

int rowsMatrix = IsReadNumber("Введите количество строк");
int colomnsMatrix = IsReadNumber("Введите количество столбцов");
int [,] myMatrix = IsCreatMatrix(rowsMatrix, colomnsMatrix);
IsPrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine($"Минимальаня сумма элементов в {IsCheckForMin(SumNum(myMatrix))} строке");