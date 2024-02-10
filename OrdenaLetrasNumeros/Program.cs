using System;
using System.Collections.Generic;

namespace OrdenaLetrasNumeros;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "8d3j74a2kz1";
        var result = Ordenar(inputString);
        Console.WriteLine(result);
    }

    static string Ordenar(string input)
    {
        var resultado = new List<string>();

        var letras = new List<string>();
        var numbers = new List<string>();

        foreach (var valor in input)
        {
            try
            {
                var result = int.Parse(valor.ToString()) * 1;
                numbers.Add(valor.ToString());
            }
            catch
            {
                letras.Add(valor.ToString());
            }
        }

        letras.Sort();
        numbers.Sort();

        int tamanho = Math.Max(letras.Count, numbers.Count);

        for (var i = 0; i < tamanho; i++)
        {
            try
            {
                resultado.Add(letras[i]);
            }
            catch { }

            try
            {
                resultado.Add(numbers[i]);
            }
            catch { }
        }

        return string.Join("", resultado);

    }
}

