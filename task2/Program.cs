/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.WriteLine(array[i]);
    }
}

int valueInt = new Random().Next(100, 1000);

int[] array = new int[3];


array[0] = valueInt / 100;
array[1] = valueInt % 100 / 10;
array[2] = valueInt % 10; 

int[] array2 = new int[2];
array2[0] = array[0];
array2[1] = array[2];

int valueInt2 = array2[0] * 10 + array2[1];

Console.WriteLine($"После удаления второй цифры трёхзначного числа {valueInt} получится число {valueInt2}");