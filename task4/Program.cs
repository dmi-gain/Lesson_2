/* Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите число в диапазоне от 1 до 7: ");
string value = Console.ReadLine();
int valueInt = int.Parse(value);

if (valueInt == 1) {
    Console.WriteLine("Понедельник");
   }    else if (valueInt == 2) {
        Console.WriteLine("Вторник");
        }   else if (valueInt == 3) {
            Console.WriteLine("Среда");
            }   else if (valueInt == 4) {
                Console.WriteLine("Четверг");
                }   else if (valueInt == 5) {
                    Console.WriteLine("Пятница");
                    }   else if (valueInt == 6) {
                            Console.WriteLine("Суббота");
                        }   else if (valueInt == 7) {
                                    Console.WriteLine("Воскресенье");
                            }   else {
                                Console.Write("Введите число в диапазоне от 1 до 7: ");
} 

if (valueInt > 0 && valueInt < 6)
{
    Console.WriteLine("Это будний день");
}
else if (valueInt == 6 || valueInt == 7)
{
    Console.WriteLine("Это выходной день");
}

