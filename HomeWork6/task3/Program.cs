// задача от преподавателя)
// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"


// while(Console.ReadKey(true)==Keys.Enter){

int IsReadNumber(string messageToUser){
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool InputAndVerification(int n){
    bool stop = true;
    int i = 0;
    while(true){
        n = IsReadNumber("Введите число");
        if(n > 0){
            i++;
        }
        else{
            stop = false;
            break;
        }
    }
    return stop;
}

int N = IsReadNumber("  Введите число");
bool res = InputAndVerification(N);
Console.WriteLine(res);