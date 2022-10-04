// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Программа для поиска точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
int count = 0;
int k1 = 0;
int b1 = 0;
int b2 = 0;
int k2 = 0;

while (count < 4)
{
    Console.Write("\nВведите значение " + ChooseSign(count) + " : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if(count == 0) b1 = number;
        else if(count == 1) k1 = number;
        else if(count == 2) b2 = number;
        else k2 = number;
        count++;
    }
    else Console.WriteLine("Некорректно указано значение!\n");
}

Console.Write("\nДля введённых значений b1 = " + b1 + ", k1 = " + k1 + ", b2 = " + b2 + " и k2 = " + k2);
Console.WriteLine("\nКоордината точки пересечения = (" + CalcX() + ";" + CalcY() + ")");

double CalcX()
{
    return Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2);
}

double CalcY()
{
    return Convert.ToDouble(k1) * (Convert.ToDouble(b2 - b1) / Convert.ToDouble(k1 - k2)) + Convert.ToDouble(b1);
}

string ChooseSign(int count)
{
    if(count == 0) return "b1";
    else if(count == 1) return "k1";
    else if(count == 2) return "b2";
    else return "k2";
}