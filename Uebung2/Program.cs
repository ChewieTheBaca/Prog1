using System;

namespace Uebung2
{
    class Test
    {
        static void Main(string[] args)
        {
                    //Aufgabe 1
                    int x=0;
                    for (int i=1;i<=100;i++){
                        x+=i;
                    }
                    Console.WriteLine(x);

                    //Aufgabe 2
                    int y=0;
                    for (int i=200;i<=300;i=i+2){
                        y+=i;
                    }
                    Console.WriteLine(y);

                    //Aufabe 3
                    int z=0;
                    for (int i=1;i*i<200;i++){
                        z=i*i;
                        if(z<200){
                            Console.WriteLine(z);
                        }
                        else break;
                    }

                    //Aufgabe 4

                    Console.WriteLine("Bitte eine Zahl eingeben");
                    string eingabe = Console.ReadLine();
                    int a = int.Parse(eingabe);
                    int zws = 0;
                    int zwsquad =0;

                    for (int i=1;i<=15;i++){
                        zws=a+i;
                        zwsquad=zws*zws;
                        Console.WriteLine(zws+" "+zwsquad);
                    }

                    //Aufabe 5

                    double summe=0;
                    int vz = 1;
                    for (int i=1;i<=1000;i++){
                        if (i%2==0){vz=(-1);}
                        else {vz=1;}
                        summe = summe + vz*(1D/i);
                    }
                    Console.WriteLine(summe);
                    if ((summe - Math.Log(2))<0.001){
                        Console.WriteLine("Erfolg!");
                    }

                    //Aufgabe 6

                    int fib1 = 1;
                    int fib2 = 0;
                    int fib = 0;

                    for (int i=0;i<=1000000;i++){
                        //if(i<=2){Console.WriteLine(i);}

                        fib = fib1 + fib2;
                        fib1 = fib;
                        fib2 = fib1;

                        if(fib>1000000){break;}
                        Console.WriteLine(fib);
                        }

                    //Aufgabe 7

                    double s=0;
                    double zaehler=1;

                    for (int i=1;i<=1000;i++){
                        if(i%2==0)s=s-1/zaehler;
                        if(i%2==1)s=s+1/zaehler;
                        zaehler=zaehler+2;
                        Console.WriteLine(s);
                        if((s-(Math.PI/4))<=0.001)Console.WriteLine("Erfolg!");
                    }
            //Aufagbe 8
            char[] valid = new char[] { 'p', 'P', 'r', 'R', 'o', 'O', 'g', 'G' };
            char[] passwort = new char[4];
            string zeichen = "";
            // Loesung mit Arrays
            //Zeicheneingabe und Speicherung in char-Array

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Passwort eingeben: ");
                string input = Console.ReadLine();

                if (input.Length > 4)
                {
                    Console.WriteLine("Passwort zu lang!");
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (input[i] == valid[k])
                        {
                            zeichen += valid[k];
                        }
                    }
                }
                if (zeichen.Length == 4)
                {
                    Console.WriteLine("Passwort ist richtig!");
                    break;
                }
                else if (j >= 3) Console.WriteLine("Passwort 3x falsch!");
                else Console.WriteLine("Passwort ist falsch");
            }

            //Loesung ohne Arrays
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Zeichen 1 eingeben: ");
                Console.WriteLine();
                char eins = Console.ReadKey().KeyChar;

                Console.WriteLine("Zeichen 2 eingeben: ");
                Console.WriteLine();
                char zwei = Console.ReadKey().KeyChar;

                Console.WriteLine("Zeichen 3 eingeben: ");
                Console.WriteLine();
                char drei = Console.ReadKey().KeyChar;

                Console.WriteLine("Zeichen 4 eingeben: ");
                Console.WriteLine();
                char vier = Console.ReadKey().KeyChar;

                string test = "";

                if (eins == 'p' || eins == 'P' ||
                    eins == 'r' || eins == 'R' ||
                    eins == 'o' || eins == 'O' ||
                    eins == 'g' || eins == 'G')
                {
                    test += "*";
                }

                if (zwei == 'p' || zwei == 'P' ||
                    zwei == 'r' || zwei == 'R' ||
                    zwei == 'o' || zwei == 'O' ||
                    zwei == 'g' || zwei == 'G')
                {
                    test += "*";
                }

                if (drei == 'p' || drei == 'P' ||
                    drei == 'r' || drei == 'R' ||
                    drei == 'o' || drei == 'O' ||
                    drei == 'g' || drei == 'G')
                {
                    test += "*";
                }

                if (vier == 'p' || vier == 'P' ||
                    vier == 'r' || vier == 'R' ||
                    vier == 'o' || vier == 'O' ||
                    vier == 'g' || vier == 'G')
                {
                    test += "*";
                }


                if (test == "****")
                {
                    Console.WriteLine("Passwort richtig!");
                    break;
                }
                
                
                if (i == 2)
                {
                    Console.WriteLine("Passwort 3x falsch!");
                    break;
                }
                Console.WriteLine("Passwort ist falsch!");
            }






        }

    }
}