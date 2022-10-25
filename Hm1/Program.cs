// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 // Тут правильно должно быть 4, возможно просто опечатка

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        System.Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int PosNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]>0)
       {
            count += 1;
       } 
    }
    return count;
}

int value = Prompt("Сколько чисел хотите ввести? = ");
int[] array = CreateArray(value);
int count = PosNums(array);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел больше нуля = {count}");
