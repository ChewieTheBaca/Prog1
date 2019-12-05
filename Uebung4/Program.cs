using System;

namespace Uebung4
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "";
            string two = "";
            binaryAdd(one, two);
        }

        //Aufgabe 1

        static void binaryAdd(string first, string second)
        {
            System.Console.WriteLine("Zahl eins fuer Binaeradd eingeben: ");
            first = Console.ReadLine();
            System.Console.WriteLine("Zahl zwei fuer Binaeradd eingeben");
            second = Console.ReadLine();

            int biggerLength = 0;
            if (first.Length - second.Length > 0) biggerLength = first.Length;
            else biggerLength = second.Length;

            int sum = 0;
            int overflow = 0;
            int num1, num2 = 0;
            int sumLength = biggerLength;
            string line = new String('-', biggerLength + 2);
            string overflowPos = "";
            string result = "";



            //schriftliche Addition
            for (int i = 0; i < (sumLength += overflow); i++)
            {
                overflow = 0;

                if (i < first.Length) num1 = int.Parse(first[first.Length - 1 - i].ToString());
                else num1 = 0;
                if (i < second.Length) num2 = int.Parse(second[second.Length - 1 - i].ToString());
                else num2 = 0;
                sum = num1 + num2;
                if (sum > 1)
                {
                    overflow = 1;
                    sum = 0;
                }

                if (i < biggerLength & overflow > 0) result = overflow + sum + result;
                else result = sum + result;

                if (overflow > 0) overflowPos = new String(' ', biggerLength - i) + overflow;
                else overflowPos = new String(' ', biggerLength - i);

                System.Console.WriteLine("  " + first);
                System.Console.WriteLine("+ " + second);
                System.Console.WriteLine(overflowPos);
                System.Console.WriteLine(line);
                System.Console.WriteLine(new String(' ', biggerLength - i + 1) + result);
                System.Console.WriteLine();

            }
        }
    }
}
