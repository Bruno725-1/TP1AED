using System;
class Program {
    public static void Main (string[] args) {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++) {
            string entrada = Console.ReadLine();
            string[] strings = entrada.Split(' ');
            string a = strings[0];
            string b = strings[1];
            int operacoes = CalcularOperacoes(a, b);
            Console.WriteLine(operacoes);
        }
    }
    public static int CalcularOperacoes (string a, string b) {
        int operacoes = 0;
        for (int i = 0; i < a.Length; i++) {
            int distancia = (b[i] - a[i] + 26) % 26;
            operacoes += distancia;
        }
        return operacoes;
    }
}