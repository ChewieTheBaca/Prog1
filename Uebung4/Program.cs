using System;

namespace Uebung4
{
    class Program
    {
        static void Main(string[] args)
        {

            //  string one = "";
            //  string two = "";
            //  binaryAdd(one, two);
            Program prgm = new Program();
            prgm.parseBinaryAndDecimal("");
        }


        //Aufgabe 1

        /*         static void binaryAdd(string first, string second)
                {

                    System.Console.WriteLine("Zahl eins fuer Binaeradd eingeben: ");
                    first = Console.ReadLine();
                    System.Console.WriteLine("Zahl zwei fuer Binaeradd eingeben");
                    second = Console.ReadLine();
                    int sumLength = 0;
                    if (first.Length - second.Length > 0) sumLength = first.Length;
                    else sumLength = second.Length;

                    int sum = 0;
                    int overflow = 0;
                    int lastOverflow = 0;
                    int num1, num2 = 0;

                    string result = "";
                    string line = new String('-', sumLength + 2);
                    string overflowPos = "";

                    //schriftliche Addition
                    for (int i = 0; i <= (sumLength += overflow); i++)
                    {
                        if (i < first.Length) num1 = int.Parse(first[first.Length - 1 - i].ToString());
                        else num1 = 0;
                        if (i < second.Length) num2 = int.Parse(second[second.Length - 1 - i].ToString());
                        else num2 = 0;

                        sum = num1 + num2 + lastOverflow;
                        if (sum > 1)
                        {
                            overflow = 1;
                            sum = 0;
                        }

                        if (i == sumLength & lastOverflow == 1)
                        {
                            result = lastOverflow + result;
                            drawBinaryAdd();
                            break;
                        }
                        else
                        {
                            result = sum + result;
                            drawBinaryAdd();
                            lastOverflow = overflow;
                            overflow = 0;
                        }

                        void drawBinaryAdd()
                        {
                            if (overflow > 0) overflowPos = new String(' ', sumLength - i) + overflow;
                            else overflowPos = new String(' ', sumLength - i);

                            if (first.Length == sumLength)
                            {
                                System.Console.WriteLine("  " + first);
                                System.Console.WriteLine("+" + new String(' ', sumLength - second.Length + 1) + second);
                                System.Console.WriteLine(overflowPos);
                                System.Console.WriteLine(line);
                                System.Console.WriteLine(new String(' ', sumLength - i + 1) + result);
                                System.Console.WriteLine();
                            }
                            else
                            {
                                System.Console.WriteLine(new String(' ', sumLength - first.Length + 2) + first);
                                System.Console.WriteLine("+ " + second);
                                System.Console.WriteLine(overflowPos);
                                System.Console.WriteLine(line);
                                System.Console.WriteLine(new String(' ', sumLength - i + 1) + result);
                                System.Console.WriteLine();
                            }
                        }

                    }
                } */

        //Aufgabe 2
        // Summe zweier Zahlen in Dezimal- und Binaersystem ausgeben

        string parseBinaryAndDecimal(string binary)
        {
            System.Console.WriteLine("Bitte Binaerzahl eingeben");
            binary = Console.ReadLine();
            double decNum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (int.Parse(binary[binary.Length - i - 1].ToString()) == 1)
                {
                    decNum += Math.Pow(2, i);
                    System.Console.WriteLine(decNum);
                }
            }
            return decNum.ToString();
        }
    }
}
