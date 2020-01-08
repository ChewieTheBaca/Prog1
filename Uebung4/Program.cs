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
            //prgm.parseBinaryAndDecimal("");

            //System.Console.WriteLine("Bitte Binaerzahlen fuer Mult eingeben: ");
            //prgm.binaryMult(Console.ReadLine(), Console.ReadLine());
            double[,] matrix = prgm.createMatrix(4, 4);
            prgm.fillRandom(ref matrix);
            prgm.printMatrix(matrix);
        }


        //Aufgabe 1

        string binaryAdd(string first, string second)
        {


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
                    //drawBinaryAdd();
                    break;
                }
                else
                {
                    result = sum + result;
                    //drawBinaryAdd();
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
            return result;

        }

        //Aufgabe 2
        // Summe zweier Zahlen in Dezimal- und Binaersystem ausgeben

        string parseBinaryAndDecimal(string binary)
        {

            double decNum = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (int.Parse(binary[binary.Length - i - 1].ToString()) == 1)
                {
                    decNum += Math.Pow(2, i);
                }
            }
            System.Console.WriteLine("Dezimalzahl: " + decNum);
            System.Console.WriteLine("Binaerzahl: " + binary);
            return decNum.ToString();
        }

        //Aufgabe 3
        // schriftliche Multiplikation

        string binaryMult(string first, string second)
        {
            // generate Numbers for addition
            int num1 = 0, num2 = 0, realProd = 0;
            string[] product = new string[first.Length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int k = 0; k < second.Length; k++)
                {
                    num1 = int.Parse(first[first.Length - i - 1].ToString());
                    num2 = int.Parse(second[second.Length - k - 1].ToString());
                    realProd = num1 * num2;
                    product[i] = realProd + product[i];
                }
            }
            //fill up with 0 to match the number position
            for (int i = product.Length - 1; i >= 0; i--)
            {
                product[i] = product[i] + new String('0', i);
            }
            //use binaryAdd for Addition
            for (int i = 1; i < product.Length; i++)
            {
                product[0] = binaryAdd(product[0], product[i]);
            }
            //print result with parseBinaryAndDecimal()
            parseBinaryAndDecimal(product[0]);

            return product[0];
        }

        //Aufagbe 4

        double[,] createMatrix(int lines, int columns)
        {
            double[,] matrix = new double[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    matrix[i, k] = 0;
                }
            }
            return matrix;
        }

        //Aufagbe 5        
        void fillRandom(ref double[,] matrix, int lowerRange = -10, int maxRange = 10)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Random rnd = new Random();
                    matrix[i, k] = rnd.Next(lowerRange, maxRange + 1);
                    System.Console.WriteLine("Matrix filled with rnd numbers: " + matrix[i, k]);
                }
            }
        }

        //Aufgabe 6
        void printMatrix(double[,] m)
        {
            string lines = "";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int k = 0; k < m.GetLength(1); k++)
                {
                    lines += " " + m[i, k];
                }
                System.Console.WriteLine(lines);
                lines = "";
            }
        }

        //Aufgabe 7
        //
    }

}
