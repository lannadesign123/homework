// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3


/*Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"число {a} больше {b} ");
}
else
{
    Console.WriteLine($"число {b} больше {a} ");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a >= b && a >= c) { max = a; }
if (b >= a && b >= c) { max = b; }
if (c >= b && c >= a) { max = c; }

{
    Console.WriteLine($"Максимальное число {max} ");
}
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


/*Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());

if (a % 2 == 0) 
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= N && current % 2 == 0);
{
    Console.Write(current + " ");
    current++;
}