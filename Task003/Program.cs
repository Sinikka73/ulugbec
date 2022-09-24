Console.WriteLine("Введите целое число от 1 до 7");
int daynumber = Convert.ToInt32(Console.ReadLine());

if(daynumber == 1) Console.WriteLine("Понедельник"); 
else if(daynumber == 2) Console.WriteLine("Вторник"); 
else if(daynumber == 3) Console.WriteLine("Среда"); 
else if(daynumber == 4) Console.WriteLine("Четверг"); 
else if(daynumber == 5) Console.WriteLine("Пятница"); 
else if(daynumber == 6) Console.WriteLine("Суббота"); 
else if(daynumber == 7) Console.WriteLine("Воскресенье");
else if(daynumber > 7) Console.WriteLine("Введите число от 1 до 7");
else if(daynumber < 1) Console.WriteLine("Введите число от 1 до 7");







 