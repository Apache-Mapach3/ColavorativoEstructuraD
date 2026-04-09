using System;
class Program
{
    static void Main()
    {
        int[] arreglo = new int[10];
        Random rand = new Random();
        //inicialización con valores aleatorios//
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = rand.Next(1, 100);
        }
        Console.WriteLine("Arreglo original:");
        ImprimirFor(arreglo);
        //recorrido con foreach//
        Console.WriteLine("\nRecorrido con foreach:");
        ImprimirForeach(arreglo);
        //busqueda lineal//
        Console.Write("\nIngrese valor a buscar: ");
        int objetivo = int.Parse(Console.ReadLine());
        int indice = BusquedaLineal(arreglo, objetivo);
        if (indice != -1)
            Console.WriteLine($"Valor {objetivo} encontrado en el índice {indice}");
        else
            Console.WriteLine($"Valor {objetivo} no encontrado");
        //modifica impares a cero//
        CambiarImparesACero(arreglo);
        Console.WriteLine("\nArreglo después de cambiar impares por 0:");
        ImprimirFor(arreglo);
        //multiplicar por indice//
        MultiplicarPorIndice(arreglo);
        Console.WriteLine("\nArreglo después de multiplicar por índice:");
        ImprimirFor(arreglo);
    }
    //imprimir con for clasico//
    static void ImprimirFor(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    //imprimir con foreach//
    static void ImprimirForeach(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    //cambiar impares a 0//
    static void CambiarImparesACero(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                arr[i] = 0;
            }
        }
    }
    //multiplicar por indice//
    static void MultiplicarPorIndice(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= i;
        }
    }
    //busqueda lineal//
    static int BusquedaLineal(int[] arr, int valor)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == valor)
            {
                return i;
            }
        }
        return -1;
    }
}