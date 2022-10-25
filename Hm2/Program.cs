// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = Prompt("Введите значение k1 = ");
double k2 = Prompt("Введите значение k2 = ");
double b1 = Prompt("Введите значение b1 = ");
double b2 = Prompt("Введите значение b2 = ");

void Condition(double k1, double k2, double b1, double b2)
{
    double x, y;
    if ((k1 == k2) && (b1 == b2))
    {
        System.Console.WriteLine("Прямые совпадают");
    }

    else if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }

    else
    {

        x = (b2 - b1) / (k1 - k2);

        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

        System.Console.WriteLine($"({x}, {y})");

    }
}

Condition(k1, k2, b1, b2);
