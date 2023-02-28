// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int valeu = int.Parse(Console.ReadLine());
    return valeu;
}

int[] IsRandomArray(int length){
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next();
    }
    return array;
}

int IsSumI(int[] array){
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2){
        sum = sum + array[i];
    }
    return sum;
}

int lengthOfArray = IsReadNumber("Введите длину массива");
int[] array = IsRandomArray(lengthOfArray);

Console.WriteLine($"[{string.Join(", ", array)}]");

double sumI = IsSumI(array);
Console.WriteLine(sumI);