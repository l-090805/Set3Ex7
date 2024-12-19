namespace Set3Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vector");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(" "), int.Parse);
            int aux = 0;
            int n = v.Length;

            for (int i = 0; i < n / 2; i++)
            {
                aux = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = aux;

            }
            Console.WriteLine("vector inversat: " + string.Join(" ", v));
        }
    }
}
