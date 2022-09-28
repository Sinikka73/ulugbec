for(int i = 0; i < 10; i++)
{
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    {
     int result = num1 % num2;
        if(result == 0)
            {
                Console.WriteLine($"Число{num2} кратно числу {num1}.");
            }
        else 
            {
                Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток {result}.");
            }    

    }
else 
    {
        Console.WriteLine("Первое число должно быть больше второго!");
    }
}