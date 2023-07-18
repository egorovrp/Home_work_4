//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double Promt(string message)
{
    Console.Write(message);
	double num = double.Parse(Console.ReadLine()!);
	return num;
}

double Step (double a, double b)
{
	double result = Math.Pow(a , b);
	return result;
}

double A = Promt ("Введите число A: ");
double B = Promt ("Введите число B: ");
double Res = Step(A,B);
Console.Write("Результат возведения в степень: " + Res);