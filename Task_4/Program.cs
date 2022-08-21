Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
for(int i = 2; i< N+1; i++)
{
   if((i % 2) == 0)

    Console.Write(i+ " ");
}
