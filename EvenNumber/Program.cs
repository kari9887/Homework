Console.Write("Введите число: ");

int NumberA = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(NumberA > 1)
{
    while(evenNumber <= NumberA)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
