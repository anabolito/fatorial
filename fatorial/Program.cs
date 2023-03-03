internal class Program
{
    private static void Main(string[] args, int fatN)
    {
        int n, i;
        Console.Write("Escolha um número para calcular a fatorial: ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i < n; i++)
        {
            n = n * i;

        }

        Console.WriteLine(n);
}
}