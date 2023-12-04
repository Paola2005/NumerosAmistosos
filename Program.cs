using System;

class NumerosAmistosos
{
    public static void Main()
    {
        Console.WriteLine("Pares amigables en el rango [1000, 1500]:");
        BuscarParesAmigables(1000, 1500);
    }

    static void BuscarParesAmigables(int rangoInicio, int rangoFin)
    {
        for (int m = rangoInicio; m <= rangoFin; m++)
        {
            int n = SumaDivisores(m);
            if (n > m && n <= rangoFin && SumaDivisores(n) == m)
            {
                Console.WriteLine($"({m}, {n}) son pares amigables.");
            }
        }
    }

    static int SumaDivisores(int numero)
    {
        int suma = 1; 

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                suma += i;


                if (i != numero / i)
                {
                    suma += numero / i;
                }
            }
        }

        return suma;
    }
}