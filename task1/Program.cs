/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.WriteLine(array[i]);
    }
}

Console.WriteLine("Введите трёхзначное число:");
string value = Console.ReadLine();
int valueInt = int.Parse(value);
int[] array = new int[3];

array[0] = valueInt / 100;
array[1] = valueInt % 100 / 10; 
array[2] = valueInt % 10; 

if (valueInt > 99 && valueInt < 1000)
{
    Console.WriteLine($"Вторая цифра трёхзначного числа {valueInt} равна {array[1]}");
}
else 
    Console.WriteLine($"Введите трёхзначное число");






    

