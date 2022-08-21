Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
	//Console.Writeline("Ура, это же МАША!");
	Console.WriteLine("Ура, это же МАША!");
}
else
{
	Console.Write("Привет, ");
	Console.WriteLine(username);
}
