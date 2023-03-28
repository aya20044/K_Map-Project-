// See https://aka.ms/new-console-template for more information
using System;
namespace K_Map3
{
    class Program
    {
        static void Main(string[] args)
        {


            int numberofvariables = 0;
            Console.WriteLine(" What is the number of variables?");
            numberofvariables = int.Parse(Console.ReadLine());
            if (numberofvariables == 3)
            {


                Console.WriteLine("What is the number of minterms?");
                int size2 = int.Parse(Console.ReadLine());
                string[] array4 = new string[size2];
                for (int k = 0; k < array4.Length; k++)
                {
                    Console.WriteLine(" Enter the minterm number " + (k + 1));
                    array4[k] = Console.ReadLine();
                }
                int row2 = 2;
                int column2 = 4;
                int[,] array3 = new int[row2, column2];
                for (int n = 0; n < array4.Length; n++)
                {
                    if (array4[n] == "x`y`z`") array3[0, 0] = 1;
                    if (array4[n] == "x`yz`") array3[0, 1] = 1;
                    if (array4[n] == "x`yz") array3[0, 2] = 1;
                    if (array4[n] == "x`y`z") array3[0, 3] = 1;
                    if (array4[n] == "xy`z`") array3[1, 0] = 1;
                    if (array4[n] == "xyz`") array3[1, 1] = 1;
                    if (array4[n] == "xyz") array3[1, 2] = 1;
                    if (array4[n] == "xy`z") array3[1, 3] = 1;
                }
                int sum = 0;
                for (int c = 0; c < row2; c++)
                {
                    for (int m = 0; m < column2; m++)
                    {

                        sum += array3[c, m];
                        if (sum == 8) { Console.WriteLine(" The simplification form is: 1"); }
                    }

                }
                int sum2 = 0;
                for (int c2 = 0; c2 < row2; c2++)
                {
                    for (int m2 = 0; m2 < column2; m2++)
                    {

                        sum2 += array3[c2, m2];
                        

                    }
                    if (sum2 == 1)
                    {
                        if (array3[0, 0] == 1) Console.WriteLine(" The simplification form is: x`y`z`");
                        if (array3[0, 1] == 1) Console.WriteLine(" The simplification form is: x`yz`");
                        if (array3[0, 2] == 1) Console.WriteLine(" The simplification form is: x`yz");
                        if (array3[0, 3] == 1) Console.WriteLine(" The simplification form is: x`y`z");
                        if (array3[1, 3] == 1) Console.WriteLine(" The simplification form is: xy`z");
                        if (array3[1, 2] == 1) Console.WriteLine(" The simplification form is: xyz");
                        if (array3[1, 1] == 1) Console.WriteLine(" The simplification form is: xyz`");
                        if (array3[1, 0] == 1) Console.WriteLine(" The simplification form is: xy`z`");





                    }


                }
            }
        }
    }
}

