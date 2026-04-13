using System;
class Program
{
    static void Main()
    {
        //inicializacion//
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);
        
        //recorrido por columnas//
        Console.WriteLine("\nRecorrido por columnas:");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, j] + " ");
            }
        }
        Console.WriteLine();
        
        //suma los elementos//
        int suma = 0;
        foreach (int valor in matriz)
        {
            suma += valor;
        }
        Console.WriteLine($"\nSuma total: {suma}");
        
        //intercambia filas//
        IntercambiarFilas(matriz, 0, 2);

        Console.WriteLine("\nMatriz despues de intercambiar filas:");
        ImprimirMatriz(matriz);
    }
    
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    
    static void IntercambiarFilas(int[,] matriz, int fila1, int fila2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int temp = matriz[fila1, j];
            matriz[fila1, j] = matriz[fila2, j];
            matriz[fila2, j] = temp;
        }
    }
}