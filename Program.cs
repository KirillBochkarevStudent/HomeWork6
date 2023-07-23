//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Task41()
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    string input = Console.ReadLine();
    int number = Convert.ToInt32(input);
    Console.WriteLine("Введите числа: ");
    int size = number;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write(";\b\b\b -> ");
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    Console.WriteLine($"Вы ввели {sum} число(числа) больше нуля");
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Task43()
{
    Console.Write("Введите значение b1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1 = ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2 = ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    int x = (b1 - b2) / (k2 - k1);
    int y = k1 * x + b1;
    Console.Write($"Точкой пересечения двух прямых является точка А({x}; {y})");
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 41)
{
    Task41();
}
else if (number == 43)
{
    Task43();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}

