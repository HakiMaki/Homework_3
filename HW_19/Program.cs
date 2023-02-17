Console.WriteLine ("Введите 5-ти значное число: ");
string N = Console.ReadLine()!;
int pal = N.Length;

if (pal == 5)
{
    if (N[0] == N[4] && N [1] == N[3])
    {
        Console.WriteLine(N + " Палиндром");
    }

    else
    {
        Console.WriteLine(N + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}
