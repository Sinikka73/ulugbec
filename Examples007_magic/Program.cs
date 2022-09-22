Console.Clear(); // Clean console 
Console.SetCursorPosition(10, 10);// Distant from left edge and from above edge
Console.WriteLine("+");

int xa = 40, ya = 1, //Задаём координаты трёх точек
    xb = 1, yb = 30,
    xc = 80, yc =30; 

Console.SetCursorPosition(xa, ya); //Выводим на экран в терминале заданные точки
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = ya; //Задаём координаты стартовой точки

int count = 0;//Задаём счётчик

while(count < 10000)//Условие пока...
{
    int what = new Random().Next(0, 3); //[0;3)  0 1 2 
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count = count + 1;

}
    





