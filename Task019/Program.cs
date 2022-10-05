int getQuaterFromCoordinateFromUser()//Упреждение неправильного введения координат (введите целое число)
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

int X1 = 0;
int Y1 = 0;
int X2 = 0;
int Y2 = 0;
Console.WriteLine("Введите координаты точек");

Console.Write("Координата X первой точки:   ");
X1 = getQuaterFromCoordinateFromUser();

Console.Write("Координата Y первой точки:   ");
Y1 = getQuaterFromCoordinateFromUser();

Console.Write("Координата X второй точки:   ");
X2 = getQuaterFromCoordinateFromUser();

Console.Write("Координата Y второй точки:   ");
Y2 = getQuaterFromCoordinateFromUser();


double getDistance(int x1, int x2, int y1, int y2) //функция нахождения расстояния
{
    double resul = 0;
    resul = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
    return resul;
}

double result = getDistance(X1, X2, Y1, Y2);

Console.WriteLine($"Точки с координатами [{X1}:{Y1}] и [{X2}:{Y2}] находятся на расстоянии {result} друг от друга.");