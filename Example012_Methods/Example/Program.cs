// ЧЕТЫРЕ ТИПА МЕТОДОВ


// Вид 1 (Ничего не принимает, ничего не возвращает)
void Method1()
{
    Console.WriteLine("Автор ...");
}


// Вызов метода 1
Method1();






// Вид 2 (что то принимает, ничего не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}


// Вызов метода2
Method2("Текст сообщения");


// Вид 22 (что то принимает, ничего не возвращает) + именованые элементы
void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}


// Вызов метода22
Method22("Текст сообщения2", 4);

Method22(msg: "Текст сообщения3", count: 4);

Method22(count: 4, msg: "Текст сообщения4");  // именованые значения можно менять местами




// Вид 3 (Ничего не принимает, что-то возвращает)
int Method3()
{
    return DateTime.Now.Year;
}


// Вызов метода3
int year = Method3();
Console.WriteLine(year);






// Вид 4 (что-то принимает, что-то возвращает)
string Method4(int count, string text)
{
    int i = 0;
    //string result = "";
    string result = String.Empty;

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;

}


// Вид 42 (что-то принимает, что-то возвращает) цикл for
string Method42(int count, string text)
{
    //string result = "";
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;

}


// Вызов метода4
string res = Method4(10, "asdf");
Console.WriteLine(res);


// Вызов метода42 цикл for
string res2 = Method42(10, "z");
Console.WriteLine(res2);







// цикл в цикле
Console.WriteLine("цикл в цикле:");
for (int i = 0; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} { i * j}");
    }
    Console.WriteLine("");
}




















