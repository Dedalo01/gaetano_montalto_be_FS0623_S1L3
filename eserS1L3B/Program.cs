namespace eserS1L3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimmi quanti nomi vuoi scrivere: ");
            int totalNames = int.Parse(Console.ReadLine());
            string[] names = new string[totalNames];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Inserisci il nome della {i + 1} persona: ");
                names[i] = Console.ReadLine();
            }


            Console.WriteLine();
            Console.Write("Inserisci nome da cercare nell'array di nomi creato in precedenza: ");
            string searchName = Console.ReadLine().ToLower();
            Console.WriteLine();
            bool isNameInArray = false;
            foreach (string name in names)
            {
                if (name.ToLower() == searchName)
                {
                    isNameInArray = true;
                    break;

                }
            }
            Console.WriteLine(isNameInArray ? $"Il nome \"{searchName}\" è presente nell'array." : $"Il nome \"{searchName}\" NON è presente nell'array.");
            Console.ReadKey();
        }
    }
}
