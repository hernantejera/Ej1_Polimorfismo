namespace Ej1_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Console.WriteLine($"El perro hace {perro.HacerSonido()}"); 

            Gato gato = new Gato();
            Console.WriteLine($"El gato hace {gato.HacerSonido()}");

            Vaca vaca = new Vaca();
            Console.WriteLine($"La vaca hace {vaca.HacerSonido()}");
        }
    }
}