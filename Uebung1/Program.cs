using System;

namespace Uebung1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            string zeichenkette = "Das ist meine Zeichenkette";
            Console.WriteLine("Benutzereingabe:");
            string BenutzerEingabe = Console.ReadLine();
            Console.WriteLine(zeichenkette + " " + BenutzerEingabe);

            /*Aufgabe 2
            int a = 4;
            int b = 13;
            int c = a+b+ 2147483647;
            Console.WriteLine(c);
            */

            //Aufgabe 3
            int zahl1, zahl2;
            string eingabe1;
            string eingabe2;
            Console.Write("Zahl1 eingeben: ");
            eingabe1 = Console.ReadLine();
            zahl1 = Convert.ToInt32(eingabe1);

            Console.Write("Zahl2 eingeben: ");
            eingabe2 = Console.ReadLine();
            zahl2 = Convert.ToInt32(eingabe2);
            
            if (zahl2 == 0){
                Console.Write("Division durch 0 nicht moeglich");
            }
    
            else
            {
            int summe = zahl1 + zahl2;
            int prod = zahl1*zahl2;
            int diff = zahl1-zahl2;
            int quot = zahl1/zahl2;

               Console.Write("Summe: " + summe + '\n' +
                         "Produkt :" + prod + '\n' +
                         "Differenz :" + diff + '\n' +
                         "Quotient :" + quot + '\n');
                         
            }

            //Aufgabe 4

            Console.Write("Seite a: ");
            string eing1 = Console.ReadLine();
            Console.Write("Seite b: ");
            string eing2 = Console.ReadLine();
            Console.Write("Seite c: ");
            string eing3 = Console.ReadLine();

            double a = Convert.ToDouble(eing1);
            double b = Convert.ToDouble(eing2);
            double c = Convert.ToDouble(eing3);
            double s = (a+b+c)/2;

            if ((a<0) | (b<0) | (c<0)){
                Console.Write("Kein echtes Dreieck!");
            }

            else if ((a>s)|(b>s)|(c>s)){
                Console.Write("Eine Seite laenger als s\n");
            }
            else {
            double fquad = s*(s-a)*(s-b)*(s-c);
            Console.Write("fquad: "+fquad + '\n' +"s:" +s + '\n') ;
            double f = Math.Sqrt(fquad);

            Console.Write("Flaecheninhalt nach Heron: " + f + '\n');
            }
            
            //Aufgabe 5
            Console.Write("Rechnungsbetrag eingeben: ");
            string rechnungseingabe = Console.ReadLine();
            int rechnung = Convert.ToInt32(rechnungseingabe);
            if (rechnung < 500) {
                Console.Write("Kein Rabatt!");
            }
            else if (rechnung >= 500 & rechnung <= 2000){
                rechnung = (rechnung/100)*2;
                Console.Write("Es gibt "+rechnung+" Euro Rabatt!");
            }
            else if (rechnung > 2000 & rechnung <= 5000){
                rechnung = (rechnung/100)*5;
               Console.Write("Es gibt " +rechnung+" Euro Rabatt!\n"); 
            }
            else{
                rechnung = (rechnung/100)*10;
                Console.Write("Es gibt "+rechnung+" Euro Rabatt!\n");
            }

            //Aufgabe 6
            Console.Write("Bedienstetenalter eingeben: \n");
            string alterString = Console.ReadLine();
            int alter = Convert.ToInt32(alterString);
            int praemie = 0;

            if (alter <1){
                Console.Write("Keine Praemie!\n");
            }
            else{
            if(alter>=1 & alter<6){
                praemie = 200;
            }
            if(alter>=6){
                praemie = 80 +(alter*20); 
            }
            if(alter>50){
                praemie = praemie + 50;
            }
            Console.Write("Die Praemie betraegt: \n"+praemie+'\n');
            }
        }

    }
}
