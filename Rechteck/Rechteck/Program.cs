/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Kosarials
 * Datum: 16.09.2022
 * Zeit: 11:06
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;

namespace Rechteck
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Umfang und Fläche des Rechtecks");
			Console.WriteLine("===============================");
			Console.WriteLine();
			
			//Variablen deklarieren
			
			double vLaenge;
			double vBreite;
			double vUmfang;
			double vFlaeche;
			
			Console.Write("Bitte die Länge (cm) eingeben: ");
			vLaenge = Convert.ToDouble(Console.ReadLine()); //Konsole einlesen, zu Double Konvertieren und in die Variable speichern
			
			Console.Write("Bitte die Breite (cm) eingeben: ");
			vBreite = Convert.ToDouble(Console.ReadLine());
			
			//Berechnungen
			
			vUmfang = 2 * (vLaenge + vBreite);
			vFlaeche = vLaenge * vBreite;

			//Ausgabe

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.BackgroundColor = ConsoleColor.White;
			Console.WriteLine("Der Umfang des Rechtecks beträgt " + vUmfang + " cm.");
			Console.WriteLine("Die Fläche des Rechtecks beträgt " + vFlaeche + " cm².");
			
			
			Console.ReadKey(true);
		}
	}
}