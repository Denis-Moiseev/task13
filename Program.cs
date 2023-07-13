Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length > 2)
{
    Console.Write(number[2]);
}
else
    Console.Write("Третьей цифры нет");