// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int [] IsRandomArray(int length){
    int [] array = new int [length];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}

int IsParityCheck(int[] array){
    int sumParity = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            sumParity += 1;
        }
    }
    return sumParity;
}

int lengthOfArray = IsReadNumber("Введите длину массива");
int[] array = IsRandomArray(lengthOfArray);

Console.WriteLine($"[{string.Join(", ", array)}]");

int res = IsParityCheck(array);
Console.WriteLine(res);
