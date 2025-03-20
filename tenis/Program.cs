using System;
class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            lerResultados();
        }
    }
    public static void lerResultados() {
        int[,] resultados = new int[15, 3];
        int[] vitorias = new int[101];
        int menorJogador = 100;
        int maiorJogador = 1;
        for (int i = 0; i < 15; i++) {
            string[] entrada = Console.ReadLine().Split(' ');
            int j1 = int.Parse(entrada[0]);
            int j2 = int.Parse(entrada[1]);
            int v = int.Parse(entrada[2]);
            resultados[i, 0] = j1;
            resultados[i, 1] = j2;
            resultados[i, 2] = v;
            //contagem das vitórias
            vitorias[v] = vitorias[v] + 1;
            //descobre os maiores e menores jogadores para a impressão
            if (j1 < menorJogador)
            menorJogador = j1;
            if (j2 < menorJogador)
            menorJogador = j2;
            if (j1 > maiorJogador)
            maiorJogador = j1;
            if (j2 > maiorJogador)
            maiorJogador = j2;
        }
        //imprimir os resultados
        for (int jogador = menorJogador; jogador <= maiorJogador; jogador++) {
            int c = vitorias[jogador];
            int grupo = -1;
            if (c > 4)
            grupo = 1;
            else if (c == 3 || c == 4)
            grupo = 2;
            else if (c == 1 || c == 2)
            grupo = 3;
            Console.WriteLine(jogador + " " + grupo);
        }
    }
}