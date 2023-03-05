// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:​
// 1 4 7 2 ​
// 5 9 2 3 ​
// 8 4 2 4 ​
// 1 7 -> такого числа в массиве нет

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] IsCreatMatrix(int rows, int colomns){
    int[,] matrix = new int[rows, colomns];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i,j] = Random.Shared.Next(int.MinValue, int.MaxValue);
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

int IsSearchNumber(int[,]matrix, int rows, int colomns){
    int num = 0;
    for(int i = 0; i <= rows; i++){
        for(int j = 0; j <= colomns; j++){
            if(rows-1 == i && colomns-1 == j){
                num += matrix[i,j];
                //Console.WriteLine(num);
            }
        }
    }
    return num;
}

int m = IsReadNumber("Введите количество строк");
int n = IsReadNumber("Введите количество столбцов");
int[,] myMatrix = IsCreatMatrix(m,n);
IsPrintMatrix(myMatrix);

int m1 = IsReadNumber("Введите строку, из которой надо вытащить число");
int n1 = IsReadNumber("Введите столбец, из которого надо вытащить число");
while(m < m1 || n < n1){
    Console.WriteLine();
    Console.WriteLine("Внимание! Вы ввели значение элемента массива, которого нет в текущем массиве.");
    Console.WriteLine("Попробуй снова!");
    Console.WriteLine();
    m1 = IsReadNumber("Введите строку, из которой надо вытащить число");
    n1 = IsReadNumber("Введите столбец, из которого надо вытащить число");
}
//else {
    int res = IsSearchNumber(myMatrix, m1 ,n1);
    Console.WriteLine(res);
//}