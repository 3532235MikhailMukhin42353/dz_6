/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите кличество элементов в массиве: ");
int elements = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int [elements];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine($"Чисел в массиве, которые больше 0: " + Kolichestvo(myArray));

void FillArray (int [] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите число под индексом {i}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void PrintArray (int [] myArray)
{
     for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + "\t");
    }
    Console.WriteLine();
}

int Kolichestvo (int [] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0 ) count++;
    }
    return count;
}