using System;
class Program
{
    public static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string[] numeros = entrada.Split(' ');
        for (int i = 0; i < numeros.Length; i++) {
            string numero = numeros[i];
            int tamanho = numero.Length;
            char[] invertido = new char[tamanho];
            for (int j = 0; j < tamanho; j++) {
                invertido[j] = numero[tamanho - 1 - j];
            }
            Console.WriteLine(new string(invertido));
        }
    }
}