// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] IsCreatArray(int length){
    int[] array = new int [length];
    for(int i = 0; i < array.Length; i++){
        array[i] = IsReadNumber($"Введите новый эллемент массива");
    }
    return array;
}

int CheckPositivNum(int [] array){
    int i = 0;
    int count = 0;
    while(i < array.Length){
        if(array[i] > 0){
            count++;
            i++;
        }
        else i++;
    }
    return count;
}

int lengthOfArray = IsReadNumber("Введите количество эллементов");
int[] myArray = IsCreatArray(lengthOfArray);
    if(lengthOfArray == 0){
        Console.WriteLine("Используйте другое число");
    }
    else{
    Console.WriteLine($"Ваш массив[{string.Join(", ", myArray)}]");
    int quantity = CheckPositivNum(myArray);
    Console.WriteLine(quantity);
    }
