//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль. Не использовать String!

//Тело программы

Console.Write("Введите 5-тизначное число: ");
int number = InputInt();
PalindromeCheck(number);




//Объявление функций
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

int[] PalindromeCheck(int num)
{
    int[] array1 = new int[5];

    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = num % 10;
        num = num / 10;

        Console.Write(array1[i]);
    }

    Console.WriteLine();

    while ()

    return array1;
}