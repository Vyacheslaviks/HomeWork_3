// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

//Тело программы

Console.WriteLine("Введите координаты первой точки: ");
int x1 = InputInt();
int y1 = InputInt();
int z1 = InputInt();

Console.WriteLine("Ведите координаты второй точки:");
int x2 = InputInt();
int y2 = InputInt();
int z2 = InputInt();

Console.WriteLine($"Расстояния между точками равно: {CalculateDistance(x1, y1, z1, x2, y2, z2)}");



//Обявление методов

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if (isParse)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение!");
        return -1;
    }
}

double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = 0.0;

    distance = Math.Pow (Math.Pow (x1 - x2, 2) + Math.Pow (y1 - y2, 2) + Math.Pow (z1 - z2, 2) , 0.5);

    return distance;
}