//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль. Не использовать String!

//Тело программы

Console.Write("Введите 5-тизначное число: ");
int number = InputInt();

if (PalindromeCheck(number) == 5)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}


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

int PalindromeCheck(int num)
{
    int[] array1 = new int[5]; //оригинальное число в массиве
    int[] array2 = new int[5]; //перевернутое число в массиве
    int num2 = num;
    int score = 0; //будет считать число совпавших цифр массивов

    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = num % 10;
        num = num / 10;
    }

    for (int i = array2.Length-1; i >= 0; i--)
    {
        array2[i] = num2 % 10;
        num2 = num2 / 10;
    }

    for (int i = 0; i < array1.Length; i++)
    {
        
        if (array1[i] == array2[i])
        {
            score = score + 1;
        }
    }

    return score;
}