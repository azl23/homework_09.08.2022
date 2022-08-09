// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> Четное

int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}

int number;
number = Prompt("Введите число ");
int even = number % 2;
if (even == 0)
{
System.Console.Write("Число четное "); 
}
else
{
    System.Console.Write("Число нечетное "); 
}
