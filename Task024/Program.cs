// Принимает нв вход число и выдаёт сумму чисел от 0 до введённого.
void printInConsoleColorfull(string information)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(information);
        Console.ResetColor();
    }

int getSumTillNumber(int first, int last)
    {
        int result = 0;
        if(first > last)
            {
                printInConsoleColorfull($"Верхняя граница отрицательная {last}");
                int buff = last;
                last = first;
                first = buff;
            }
        for(int i = first; i <= last; i++)
        {
        result = result + i;
        }

        return result;
    }

Console.WriteLine("Введите число  ");  
int num =  Convert.ToInt32(Console.ReadLine());//Перевод строки в формат числа
int resul = getSumTillNumber(0, num);
    if(num < 0)
    {
        Console.WriteLine($"Сумма всех чисел от {num}  до 0 равна {resul}");
    }
    else
    {
        Console.WriteLine($"Сумма всех чисел от 0 до {num} равна {resul}");
    }
     
Console.WriteLine("Hello, World!");
