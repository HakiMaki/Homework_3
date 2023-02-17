Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
if(number <0)
{
    count = number;
    number = -1;
}
while (count <= number)
{
Console.Write($"{(Math.Pow(count,3)) + ((count != number) ? ", " : "").ToString()}");
count ++;
}

