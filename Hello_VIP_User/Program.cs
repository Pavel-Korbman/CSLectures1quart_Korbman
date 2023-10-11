Console.WriteLine("Ваше Имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "лена")
{
 Console.Write("УРА!!! Привет, та самая ");
 Console.Write(username);
  Console.WriteLine("!");
}
else
{
Console.Write("Привет! ");
Console.WriteLine(username);
}