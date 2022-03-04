using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Algo
{
    class PrimeNumBetween1_1000
    {
          public static void primeNum()
            {
                bool Prime = true;
                Console.WriteLine("Prime Numbers between 1 to 1000 : ");
                for (int a = 2; a <= 1000; a++) //upper limit and lower limit are defined
                {
                    for (int b = 2; b <= 1000; b++)// base logic for the primality
                    {
                        if (a != b && a % b == 0) //modulo operators employed
                        {
                            Prime = false;
                            break;
                        }
                    }
                    if (Prime)
                    {
                        Console.Write("\t" + a); //printing the correct variable
                    }
                    Prime = true;
                }
               
            }
        }
    }