// Написать программу расчёта расстояния между точками в пространстве по их трём координатам.

int getCoordinateFromUser()//Упреждение неправильного введения координат (введите целое число)
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
int Z1 = 0;
int Z2 = 0;
Console.WriteLine("Введите координаты точек");

Console.Write("Координата X первой точки:   ");
X1 = getCoordinateFromUser();

Console.Write("Координата Y первой точки:   ");
Y1 = getCoordinateFromUser();

Console.Write("Координата Z первой точки:   ");
Z1 = getCoordinateFromUser();

Console.Write("Координата X второй точки:   ");
X2 = getCoordinateFromUser();

Console.Write("Координата Y второй точки:   ");
Y2 = getCoordinateFromUser();

Console.Write("Координата Z второй точки:   ");
Z2 = getCoordinateFromUser();


double getDistance(int x1, int x2, int y1, int y2, int z1, int z2) //функция нахождения расстояния
{
    double resul = 0;
    resul = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return resul;
}

double result = getDistance(X1, X2, Y1, Y2, Z1, Z2);

Console.WriteLine($"Точки с координатами [{X1}:{Y1}:{Z1}] и [{X2}:{Y2}:{Z2}] находятся на расстоянии {result} друг от друга.");

Console.WriteLine("Hello, World!");
