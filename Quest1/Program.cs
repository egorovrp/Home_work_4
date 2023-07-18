//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int Promt (string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine()!);
	return number;
}

int[] GetArray(int minValue, int maxValue)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
  }

int min = Promt("Введите минимальное значение числа в массиве: ");
int max = Promt("Введите максимальное значение числа в массиве: ");
int[] Massive = GetArray(min, max);
PrintArray(Massive);