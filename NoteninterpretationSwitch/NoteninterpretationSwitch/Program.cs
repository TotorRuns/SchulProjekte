internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Noteninterpretation!");
        Console.WriteLine("====================");
        Console.WriteLine();

        string vNote;

        Console.Write("Bitte geben Sie eine Note in beschreibender Form (katastrophal, ungenügend, mangelhaft, ausreichend, befriedigend, gut, sehr gut, ausgezeichnet) oder Hilfe ein: ");
        vNote = Console.ReadLine();

        switch (vNote)
        {
            case "katastrophal":
                Console.WriteLine("Note 3");
                break;
            case "ungenügend":
                Console.WriteLine("Note 4");
                break;
            case "mangelhaft":
                Console.WriteLine("Note 5");
                break;
            case "ausreichend":
                Console.WriteLine("Note 6");
                break;
            case "befriedigend":
                Console.WriteLine("Note 7");
                break;
            case "gut":
                Console.WriteLine("Note 8");
                break;
            case "sehr gut":
                Console.WriteLine("Note 9");
                break;
            case "ausgezeichnet":
                Console.WriteLine("Note 10");
                break;
            case "Hilfe":
                Console.WriteLine("Du kannst zum Aufholkurs am nächsten Mittwoch kommen");
                break;
            default:
                Console.WriteLine("Diese Note gibt es nicht.");
                break;
        }



        Console.ReadKey(true);
    }
}