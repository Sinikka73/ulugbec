//Вид 1
void Metod1()
{
    Console.WriteLine("Это Я");

}
Metod1();












//Вид 2
void Metod2(string msg)
{
    Console.WriteLine(msg);

}
Metod2( "Метод1");



void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
        {
        Console.WriteLine(msg);
        i++;
        }

}
Metod21( msg:"Текст", count: 4);
Metod21( count: 3, msg:"Текст Новый");








//Вид 3
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);



//Вид 4
string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Metod4(10, "Trifle");
Console.WriteLine(res);



string Metod5(int count, string c)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++ )
    {
        result = result + c;
    }
    return result;
}

string resul = Metod5(10, "Tur");
Console.WriteLine(resul);










for(int i = 2; i<= 10; i++)
    {
        for(int j = 2; j <= 10; j++)
            {
                Console.WriteLine($"{i} X {j} = {i * j}");
            }
            Console.WriteLine();
    }


// Дан текст. В тексте нужно все пробелы заменить черточками, 
// // // маленькие буквы “к” заменить большими “К”,
// // // a большие “С” заменить маленькими “с”.
// // // Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// s [3]   // r

string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;

        int length = text.Length;
        for(int i = 0; i < length; i++)
            {
                if(text[i] == oldValue) result = result + $"{newValue}";
                else result = result + $"{text[i]}";                            
            }      
        return result;
    }
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);




int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[]array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
         for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        //
        //
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);




