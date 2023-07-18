//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int Promt (string message)
{
	Console.Write(message);
	int number = int.Parse(Console.ReadLine()!);
	return number;
}

// int[] array = {insert}


int a1 = Promt("Введите 1 элемент массива");
int a2 = Promt("Введите 2 элемент массива");
int a3 = Promt("Введите 3 элемент массива");
int a4 = Promt("Введите 4 элемент массива");
int a5 = Promt("Введите 5 элемент массива");
int a6 = Promt("Введите 6 элемент массива");
int a7 = Promt("Введите 7 элемент массива");
int a8 = Promt("Введите 8 элемент массива");