//  ВИД №1

// void MethodName(){
//     Console.WriteLine("Автор - Виктория!");
// }
// MethodName();



//  ВИД №2

// void Method2(strins msg){
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения ");


// void Method2_1(string msg, int count){
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2_1("Текст " , 4);


// ВИД №3

// int Method3(){
//     return DataTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// ВИД №4

// string Method4(int count, string c){
//     int i = 0;
//     string result = String.Empty;
//     while (i < count){
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);


// Цикл FOR можно использовать вместо WHILE

// string Method4_1(int count, string text){
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text; 
//     }
//     return result;
// }
// string res = Method4_1(10, "b");
// Console.WriteLine(res);


// Цикл в цикле:

// Таблица умножения
// for (int i = 1; i <= 10; i++){
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



// =========  Работа с текстом  ========
// Дан текст. В тексте нужно все пробелы заменить на черточки, 
// маленькие буквы "к" на большие "K",
// а большие "С" на маленькие "c".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + " вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] == r

// string Replace(string text, char oldValue, char newValue){
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);



// ====   Отсортировать массив, выстроить его по порядку.

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array){
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array){
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);