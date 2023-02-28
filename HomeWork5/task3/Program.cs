// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

 (int, int) IsSearchMinAndMaxEl(int[] array){
     int min = array[0];
     int max = array[0];
     for(int i = 1; i < array.Length; i++){
         if(max < array[i]){
             max = array[i];
         }
         if(min > array[i]){
                 min = array[i];
         }
     }
     return (min, max);
 }

int lengthOfArray = IsReadNumber("Введите длину массива");
int[] array = IsRandomArray(lengthOfArray);

(int minNum, int maxNum) = IsSearchMinAndMaxEl(array);
int res = maxNum - minNum;

Console.WriteLine($"[{string.Join(", ", array)}] -> {res}");
// Console.WriteLine(res);
// Console.WriteLine(maxNum);
// Console.WriteLine(minNum);