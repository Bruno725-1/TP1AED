using System;
class Program {
    public static void Main (string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            string entrada = Console.ReadLine();
            string[] registro = entrada.Split(' ');
            char caractere = char.Parse(registro[0]);
            int x = int.Parse(registro[1]);
        }
    }
}