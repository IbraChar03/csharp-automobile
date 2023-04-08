using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_automobile
{
    internal class Automobile
    {
       
        public string marca { get; set;  }
        public string modello { get; set; }
        public int cilindrata { get; set; }
        public int numPorte { get; set; }
        public int marce { get; set; }
        public string colore { get; set; }
        public string carburante { get; set; }
       
        public Automobile(string marca, string modello,int  cilindrata, int numPorte, int marce, string colore, string carburante)
        {
            this.marca = marca;
            this.modello = modello;
            this.cilindrata = cilindrata;
            this.numPorte = numPorte;
            this.marce = marce;
            this.colore = colore;
            this.carburante = carburante;
        }
        public void StampaMacchina()
        {
            Console.WriteLine($"Marca : {marca}");
            Console.WriteLine($"Modello : {modello}");
            Console.WriteLine($"Cilindrata : {cilindrata}");
            Console.WriteLine($"Numero porte : {numPorte}");
            Console.WriteLine($"Numero marce : {marce}");
            Console.WriteLine($"Colore : {colore}");
            Console.WriteLine($"Carburante : {carburante}");
        
        }
        public string NomeCompleto()
        {
            return marca + " " + modello;
        }
    }
}
