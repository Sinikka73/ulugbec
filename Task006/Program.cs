Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 2;

if(result == 0) Console.WriteLine($"Число {num} чётное");
else Console.WriteLine($"Число {num} нечётное");
