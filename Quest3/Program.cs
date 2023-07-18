//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Promt (string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

int SearchNumber(int num)
{
	int sum = 0;
	int a;
	while (num != 0)
	{
		a = num%10;
		sum = sum + a;
		num = num/10;
	}
	return sum;
}

int Number = Promt ("Введите число: ");
int Res = SearchNumber(Number);
Console.WriteLine(Res);