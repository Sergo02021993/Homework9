// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void PrintInterval(int m, int n)
		{
			if(m > n)
			{
				return;
			}
			for(int i = 0; i <= n; i++)
			{
                if( i %2 == 0)
                {
                    Console.Write($"{i} ");
                }
			}
		}
		PrintInterval(1, 10);
		
		Console.WriteLine();