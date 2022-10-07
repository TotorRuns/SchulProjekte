internal class Program
{
    private static void Main(string[] args)
    {
        // Die Zahl PI befindet sich in der Klasse Math -->  Math.PI
        // Verwende 4 sinnvolle Variablen

        /*
         * Berechnung des Kreises
         * ======================
         * 
         * Bitte den Radius r in cm eingeben: 12,7
         * 
         * Die Kreiszahl PI beträgt 3,14.
         * Der Durchmesser des Kreises beträgt 25,4 cm.
         * Der Umfang des Kreises beträgt (U = d · π) 79,76 cm.
         * Die Fläche des Kreises beträgt (r² + PI) 506,4 cm².*/

        //Variablen definieren

        double vRadius;
        double vDurchmesser;
        double vUmfang;
        double vFlaeche;
        double vPI = Math.PI;

        //Ausgabe

        Console.WriteLine("Berechnung des Kreises");
        Console.WriteLine("======================");
        Console.WriteLine();
        Console.Write("Bitte den Radius r in cm eingeben: ");
        vRadius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Die Kreiszahl PI beträgt " + vPI + ".");
        vDurchmesser = 2 * vRadius;
        vUmfang = vDurchmesser * vPI;
        vFlaeche = (vRadius * vRadius) * vPI;

        //Debug ausgaben
        /*Console.WriteLine(vDurchmesser);
        Console.WriteLine(vUmfang);
        Console.WriteLine(vFlaeche);*/

        
        Console.WriteLine("Der Durchmesser des Kreises beträgt " + vDurchmesser + " cm.");
        Console.WriteLine("Der Umfang des Kreises beträgt " + vUmfang + " cm.");
        Console.WriteLine("Die Fläche des Kreises beträgt " + vFlaeche + " cm².");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey(true);
    }
}