internal class Program
{
    private static void Main(string[] args)
    {
        int n, i=1;
        Console.Write("Escolha um número para calcular o fatorial: ");
        n = int.Parse(Console.ReadLine());
        int aux = n;
        while (i < n)
        {
           aux = aux * i;
           i++;
        }

        Console.WriteLine(aux);
    }
}