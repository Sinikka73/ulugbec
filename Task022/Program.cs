int getNumberFromUser()//Упреждение неправильного введения координат (введите целое число)
    {
        int resu = 0;
        while(resu == 0)
        {
            string userLine = Console.ReadLine();
            int.TryParse(userLine, out resu);
            if(resu == 0 && userLine != "0")
                {
                   Console.WriteLine($"Введите целое число.Вы ввели [{userLine}]");
 
                }
            else
                {
                    break;
                }    
        }
    
    return resu;
    }

Console.WriteLine("Введите целое число");
int num = getNumberFromUser();
Console.Write($"Квадраты чисел от 1 до {num} следующие:");

for(int i = 1; i <= num; i++)
    {
        int resul = 0;
        resul = i*i;
        Console.Write($" {resul}");
    }
