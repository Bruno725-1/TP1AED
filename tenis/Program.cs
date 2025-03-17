using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tirar esse prompt antes de enviar para o verde");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int[,] vencedores = LeResultados();
        }
    }
    static int[,] LeResultados () {
        int[,] vencedores = new int[6, 2];

        for (int i = 0; i < 15; i++) {
            string entrada = Console.ReadLine();
            string[] resultados = entrada.Split(' ');
            int j1 = int.Parse(resultados[0]);
            int j2 = int.Parse(resultados[1]);
            int vencedor = int.Parse(resultados[2]);
            
            for (int j = 0; j < vencedores.GetLength(0); j++) {
                for (int k = 0; k < vencedores.GetLength(1); k++) {
                    vencedores[j, 1] = vencedor;
                    if (j1 == vencedor)
                    vencedores[0, k] = j1;
                    if (j2 == vencedor)
                    vencedores[0, k] = j2;
                }
            }
        }
        return vencedores;
    }
}
