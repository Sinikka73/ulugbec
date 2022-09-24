Console.WriteLine("Введите любое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count < num)
    {
        if(count % 2 == 0)
        Console.Write($"{count}, ");
    count++;
    }
