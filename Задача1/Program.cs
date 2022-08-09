// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5

int Prompt(string messege)
{
    System.Console.Write(messege);           //Ввыводит сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат
}
int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");

if (number2 > number1)
{
    System.Console.WriteLine($"Число {number2} является больше числа {number1}");
}

else
{
    System.Console.WriteLine($"Число {number1} является больше числа {number2}");
}

