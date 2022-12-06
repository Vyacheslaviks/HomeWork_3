//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
//Задание должно быть выполнено в методе и метод должен вернуть массив чисел.

//Тело программы

Console.Write("Введите число: ");
int N = InputInt();
double[] array = Calculate(N);
ArrOutToScreen(array);

//Объявление методов

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

double[] Calculate(int Num)
{
    double[] array = new double [Num];
    for (int i = 1; i <= Num; i++)
    {
        array[i-1] = Math.Pow(i, 3);
    }

    return array;
}

void ArrOutToScreen(double[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]};");
}