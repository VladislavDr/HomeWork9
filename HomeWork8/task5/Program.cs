// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] IsCreatMatrix(int rows, int colomns){
    int[,] matrix = new int[rows, colomns];
    
    for(int i = 0; i < 1; i++){
        int n = 0;
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix [i,j] = n + 1;
            n++;
        }
    }
    for(int j = 3; j < 4; j++){
        int n = 3;
        for (int i = 0; i < matrix.GetLength(0); i++){
            matrix [i,j] = n + 1;
            n++;
        }
    }
    for(int i = 3; i < 4; i++){
        int n = 6;
        for(int j = 3; j >= 0; j--){
            matrix [i,j] = n + 1;
            n++;
        }
    }
    for(int j = 0; j < 1; j++){
        int n = 9;
        for (int i = 3; i >= 1; i--){
            matrix [i,j] = n + 1;
            n++;
        }
    }
    for(int i = 1; i <= 1; i++){
        int n = 12;
        for(int j = 1; j <= 2; j++){
            matrix [i,j] = n + 1;
            n++;
        }
    }
    for(int i = 2; i <= 2; i++){
        int n = 16;
        for(int j = 1; j <= 2; j++){
            matrix [i,j] = n;
            n--;
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


int rowsMatrix = 4;
int colomnsMatrix = 4;
int [,] myMatrix1 = IsCreatMatrix(rowsMatrix, colomnsMatrix);
IsPrintMatrix(myMatrix1);