// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] IsCreatMatrix(int rows, int colomns, int width){
    int[,,] matrix = new int[rows, colomns, width];
    int n = 10;
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            for(int k = 0; k < matrix.GetLength(2); k++){
                matrix [i,j,k] = n ;
                n++;
            }
            n++;
        }
        n++;
    }
    return matrix;
}

void IsPrintMatrix(int [,,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            for(int k = 0; k < matrix.GetLength(2); k++){
                Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|");
            }
        }
        Console.WriteLine();
    }
}

int rowsMatrix = 2;
int colomnsMatrix = 2;
int widthMatrix = 2;
int [,,] myMatrix = IsCreatMatrix(rowsMatrix, colomnsMatrix, widthMatrix);
IsPrintMatrix(myMatrix);