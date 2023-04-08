namespace csharp_automobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crea la tua macchina");
            Console.Write("Inserisci la marca : ");
            string marca = Console.ReadLine();
            Console.Write("Inserisci il modello : ");
            string modello = Console.ReadLine();
            Console.Write("Inserisci la cilindrata : ");
            int cilindrata;
            while (!int.TryParse(Console.ReadLine(), out cilindrata))
                Console.WriteLine("Inserisci un numero!");
            Console.Write("Inserisci il numero di porte : ");
            int porte;
            while (!int.TryParse(Console.ReadLine(), out  porte))
                Console.WriteLine("Inserisci un numero!");
           
            Console.Write("Inserisci il numero di marce : ");
            int marce;
            while (!int.TryParse(Console.ReadLine(), out marce))
                 Console.WriteLine("Inserisci un numero!");

            Console.WriteLine("Inserisci il colore : ");
            string colore = Console.ReadLine();
            Console.WriteLine("inserisci il tipo di carburante : ");
            string carburante = Console.ReadLine();


            Automobile auto1 = new Automobile(marca, modello, cilindrata, porte, marce, colore, carburante);
            Console.WriteLine($"Il nome completo dell`auto è {auto1.NomeCompleto()}");
            Console.WriteLine("Riepilogo della tua macchina...");
            auto1.StampaMacchina();
            
           
        }
    }
}