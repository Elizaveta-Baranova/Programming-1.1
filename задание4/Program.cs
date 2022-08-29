Console.Write("Введите положительное целое число ");
int Number = Convert.ToInt32(Console.ReadLine());
int x = 1;
while (x <= Number)
{
    if (x % 2 == 0)
    Console.Write(x + " ");
    x = x + 1;
}