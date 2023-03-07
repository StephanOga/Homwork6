// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


string CrossPoint(double k1, double b1, double k2, double b2)
{
    string result = "";
    double x, y;
    if (k1 == k2)
    {
        Console.WriteLine("Эти прямые не пересекаются");
        return null;
    }
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    result += "Координаты точки пересечения: x = " + x + ", y = " + y;
    return result;
}

Console.WriteLine("Прямые заданы уравнениями вида y=kx+b. Для первой прямой введите последовательно числа k1 и b1");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите для второй прямой введите последовательно числа k1 и b2");
double c = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());

string s = CrossPoint(a, b, c, d);
Console.WriteLine(s);