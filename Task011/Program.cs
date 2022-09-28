int getRandomNumberFrontRange(int minBorder, int maxBorder)//Задаём функцмю случайного числа и её параметры
    {
        int result  =   new int();
        result = new Random().Next(minBorder, maxBorder + 1);
        return result;
    }

int randomNumber = getRandomNumberFrontRange(100, 999);//Задаём аргументы для функции случайного числа
Console.WriteLine($"Случайное значение {randomNumber}");

int getDig1FromNumber(int number)//Задаём функцмю определения первой цифры числа и её параметры
    {
        int digit1  =   new int();
        digit1 = number / 100;
        return digit1;
    }
int getDig3FromNumber(int number)
    {
        int digit3  =   new int();
        digit3 = number % 10;
        return digit3;
    }

int diGit1 = getDig1FromNumber(randomNumber);//Задаём аргументы для функции определения первой цифры числа
Console.WriteLine($"Первая цифра числа - {diGit1}");

int diGit3 = getDig3FromNumber(randomNumber);
Console.WriteLine($"Третья  цифра числа - {diGit3}");

int lastnum = diGit1 *10 + diGit3;
Console.WriteLine($"Число без второй цифры - {lastnum}");

