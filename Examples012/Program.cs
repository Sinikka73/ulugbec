//Вид 1
void Metod1()
{
    Console.WriteLine("Это Я");

}
Metod1();












//Вид 2
void Metod2(string msg)
{
    Console.WriteLine(msg);

}
Metod2( "Метод1");



void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
        {
        Console.WriteLine(msg);
        i++;
        }

}
Metod21( msg:"Текст", count: 4);
Metod21( count: 3, msg:"Текст Новый");








//Вид 3
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);



//Вид 4
string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Metod4(100, "Trifle");
Console.WriteLine(res);





