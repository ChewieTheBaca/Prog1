using System;

namespace Uebung3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Konvertierung Dezimal zu Binaer

            Console.WriteLine("Bitte eine Zahl eingeben! ");
            int eingabe = Int32.Parse(Console.ReadLine());

            string bi_zahl = "";
            while (eingabe / 2 != 0)
            {
                bi_zahl = (eingabe % 2) + bi_zahl;
                eingabe = eingabe / 2;
            }

            bi_zahl = (eingabe % 2) + bi_zahl;
            Console.WriteLine("Binaerzahl: " + bi_zahl);


            //Kovertierung Dezimal zu Oktal
            System.Console.WriteLine("Bitte eine Zahl fuer Octalkonvertierung eingeben");

            eingabe = Int32.Parse(Console.ReadLine());
            string octa_zahl = "";
            while (eingabe / 8 != 0)
            {
                octa_zahl = (eingabe % 8) + octa_zahl;
                eingabe = eingabe / 8;
            }
            octa_zahl = (eingabe % 8) + octa_zahl;
            System.Console.WriteLine("Octalzahl: " + octa_zahl);


            //Konvertierung Dezimal zu Hexadezimal
            Console.WriteLine("Zahl fuer Hexakonvertierung eingeben");

            string hexa_num = "";
            eingabe = Int32.Parse(Console.ReadLine());

            while (eingabe / 16 != 0)
            {
                returnHexaNum(eingabe);
                eingabe = eingabe / 16;
            }

            returnHexaNum(eingabe);
            Console.WriteLine("Hexadezimalzahl: " + hexa_num);

            void returnHexaNum(int a)
            {
                switch (eingabe % 16)
                {
                    case 10:
                        hexa_num = "A" + hexa_num;
                        break;
                    case 11:
                        hexa_num = "B" + hexa_num;
                        break;
                    case 12:
                        hexa_num = "C" + hexa_num;
                        break;
                    case 13:
                        hexa_num = "D" + hexa_num;
                        break;
                    case 14:
                        hexa_num = "E" + hexa_num;
                        break;
                    case 15:
                        hexa_num = "F" + hexa_num;
                        break;
                    default:
                        hexa_num = (eingabe % 16) + hexa_num;
                        break;
                }
            }
            */

            //
            //Aufgabe 2
            //
            //Algorithmus, der nach der Anzahl zu rollender Wuerfel fragt
            //und dann fragt, wie oft gewürfelt werden soll
            //
            /*
            System.Console.WriteLine("Anzahl Wuerfel eingeben: ");
            int numCubes = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Anzahl Versuche eingeben: ");
            int numTries = int.Parse(Console.ReadLine());

            int[] cubes = new int[numCubes];

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

            for (int i = 0; i < numTries; i++)
            {
                for (int k = 0; k < numCubes; k++)
                {
                    Random rnd = new Random();
                    cubes[k] = rnd.Next(1, 7);
                    if (cubes[k] == 1) num1 += 1;
                    if (cubes[k] == 2) num2 += 1;
                    if (cubes[k] == 3) num3 += 1;
                    if (cubes[k] == 4) num4 += 1;
                    if (cubes[k] == 5) num5 += 1;
                    if (cubes[k] == 6) num6 += 1;

                }
            }
            System.Console.WriteLine("Augenzahl:               Anzahl:");
            System.Console.WriteLine("eins:                     " + num1);
            System.Console.WriteLine("zwei:                     " + num2);
            System.Console.WriteLine("drei:                     " + num3);
            System.Console.WriteLine("vier:                     " + num4);
            System.Console.WriteLine("fuenf:                    " + num5);
            System.Console.WriteLine("sechs:                    " + num6);
            */

            //
            // Aufgabe 3
            //
            // Schreiben Sie ein C#-Programm, 
            // welches nacheinander die Anzahl der Primzahlen 
            // in den Intervallen [0, 1000], [1000, 2000], [2000, 3000], [3000, 4000], ... 
            // [29000, 30000] berechnet
            //

            // Intervall [0,1000]

            int anzahlPrim = 0;
            bool istPrim = true;

            int untereGrenze = 0;
            int obereGrenze = 1000;

            for (int i = untereGrenze; i <= obereGrenze; i++)
            {
                // prueft ob Primzahl ist    
                for (int k = 0; k < i; k++)
                {
                    if (k > 1 && ((i / k != 1) & (i % k == 0)))
                    {
                        istPrim = false;
                        break;
                    }
                }
                if (i > 1 && istPrim == true)
                {
                    anzahlPrim += 1;
                }
                istPrim = true;



                // Intervallverschiebung
                if (i == obereGrenze & i <= 30000)
                {
                    System.Console.WriteLine("Anzahl der Primzahlen im Intervall "
                    + untereGrenze + " - " + obereGrenze + " : " + anzahlPrim);
                    obereGrenze += 1000;
                    untereGrenze += 1000;
                    anzahlPrim = 0;
                }
            }
        }


    }

}
