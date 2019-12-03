using System;

namespace Uebung3
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
