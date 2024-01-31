namespace eserS1L3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimmi quanti numeri vuoi inserire: ");
            int totalNumbers = int.Parse(Console.ReadLine());

            int[] numbers = new int[totalNumbers];

            int sum = 0;
            double media;
            for (int i = 0; i < totalNumbers; i++)
            {
                Console.Write($"Inserisci il {i + 1}° numero: ");
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];
            }

            media = (double)sum / (double)totalNumbers;

            Console.WriteLine($"La somma di tutti i tuoi numeri è: {sum}");
            Console.WriteLine($"La media di tutti i numeri è: {media}");


            Console.ReadKey();
        }
    }
}
