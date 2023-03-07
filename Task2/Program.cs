// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Console.Write("Введите колличество чисел: ");



int value = int.Parse(Console.ReadLine());
int numberOfPositiveValues = 0;
for (int i = 0; i < value; i++)
{
  Console.WriteLine($"Введите число {i + 1}: ");
  int a = int.Parse(Console.ReadLine());
  if (a > 0)
    numberOfPositiveValues++;
}
Console.WriteLine($"Положительных чисел: {numberOfPositiveValues}");


