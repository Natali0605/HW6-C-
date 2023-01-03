// **Задача 2:** Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Equation(double b1, double k1, double b2, double k2)
{
    double x = (b1-b2) / (k2-k1);
    double y = (k2 * x) + b2;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
double EnterData(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}
Console.WriteLine("введите значение b1");
double b1 = EnterData("b1 = ");
Console.WriteLine("введите значение k1");
double k1 = EnterData("k1 = ");
Console.WriteLine("введите значение b2");
double b2 = EnterData("b2 = ");
Console.WriteLine("введите значение k2");
double k2 = EnterData("k2 = ");
Equation(b1, k1, b2, k2);
