/* Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число, большее двузначного:");
string value = Console.ReadLine();
int valueInt = int.Parse(value);
int valueX;

if (valueInt < 100) 
{
    Console.WriteLine("Третьей цифры нет, введите число, большее двузначного");
}
else if (valueInt > 99 && valueInt < 1000)
{
    valueX = valueInt % 10;
    Console.WriteLine($"Третья цифра числа {valueInt} равна {valueX}");
}
else if (valueInt > 999 && valueInt < 10000)
{
    valueX = valueInt % 100 / 10;
    Console.WriteLine($"Третья цифра числа {valueInt} равна {valueX}");
}
else if (valueInt > 9999 && valueInt <= 100000)
{
    valueX = valueInt % 1000  / 100;
    Console.WriteLine($"Третья цифра числа {valueInt} равна {valueX}");
}
else 
    Console.WriteLine("Введите число меньше 100000");