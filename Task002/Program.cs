Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите другое число для сравнения");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number2 * number2;
    
if(result == number1)
 {

            Console.WriteLine($" Число {number1} является квадратом числа {number2}");

 }

else
        {
            Console.WriteLine($" Число {number1} не является квадратом числа {number2}");
        }
