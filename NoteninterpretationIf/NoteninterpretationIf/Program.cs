
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Noteninterpretation!");
        Console.WriteLine("====================");
        Console.WriteLine();
        int vNote = 0;
        Console.Write("Bitte geben Sie Ihre Note (3-10) ein: ");
        vNote = Convert.ToInt32(Console.ReadLine());

        if (vNote == 3)
        {
            Console.WriteLine("KATASTROPHAL!!! Du hast große Lücken.");
        }
        else if (vNote == 4)
        {
            Console.WriteLine("Du hast das Thema nicht Verstanden. Die Leistung ist ungenügend.");
        }
        else if (vNote == 5)
        {
            Console.WriteLine("Du hast das Thema nicht richtig verstanden. Mangelhafte Leistung.");
        }
        else if (vNote == 6)
        {
            Console.WriteLine("Ausreichende Leistung. Es sind Unsicherheiten da.");
        }
        else if (vNote == 7)
        {
            Console.WriteLine("Du hast die Thematik allgemein verstanden. Es gibt aber ein paar Fehler.");
        }
        else if (vNote == 8)
        {
            Console.WriteLine("Du hast alles verstanden. Nur ein paar Flüchtigkeitsfehler.");
        }
        else if (vNote == 9)
        {
            Console.WriteLine("Hervorragende Leistung. Das hast du gut gemacht.");
        }
        else if (vNote == 10)
        {
            Console.WriteLine("Das ist Ausgezeichnet! Spitze!");
        }
        else
        {
            Console.WriteLine("Diese Note existiert im italienischen Notensystem nicht!");
        }
        Console.ReadKey(true);
    }
}