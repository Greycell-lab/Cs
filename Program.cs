namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaffeemaschine Bosch = new Kaffeemaschine();                   
            Bosch.macheKaffee(0.25, 1);
            Console.WriteLine($"Wasser: {Bosch.Wasser}\nBohnen: {Bosch.Bohnen}\nKaffeemenge: {Bosch.Kaffeemenge}");
        }
    }
}