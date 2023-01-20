Console.Write("Введите число: ");

int NumberA = Convert.ToInt32(Console.ReadLine());
int Div = NumberA % 2;

if(Div == 0)
{
    Console.WriteLine("Да");
}

else
{
  Console.WriteLine("Нет");  
}