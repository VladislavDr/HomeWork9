// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void IsBubbleSort(int[] inArray){
        for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++){
                if (inArray[j] > inArray[j + 1]){
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
    }

int rowsMatrix = IsReadNumber("Введите количество строк");
int colomnsMatrix = IsReadNumber("Введите количество столбцов");
int [,] myMatrix = IsCreatMatrix(rowsMatrix, colomnsMatrix);
IsPrintMatrix(myMatrix);
Console.WriteLine();

int[] col = new int[colomnsMatrix];
    for (int i = 0; i < rowsMatrix; i++){
        for (int j = 0; j < colomnsMatrix; j++){
            col[j] = myMatrix[i, j];
        }
    IsBubbleSort(col);
    Console.WriteLine($"{string.Join(" ", col)}");
}
