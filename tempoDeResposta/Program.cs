using System;
class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] temposResposta = new int[101];
        int[] pendentes = new int[101];
        bool[] temMensagemPendente = new bool[101];
        int tempoAtual = 0;
        for (int i = 0; i < 101; i++) {
            temposResposta[i] = 0;
            pendentes[i] = -1;
        }
        for (int i = 0; i < n; i++) {
            string[] registro = Console.ReadLine().Split(' ');
            char tipo = char.Parse(registro[0]);
            int x = int.Parse(registro[1]);
            if (tipo == 'R') {
                pendentes[x] = tempoAtual;
                temMensagemPendente[x] = true;
                tempoAtual++;
            } else if (tipo == 'E') {
                if (temMensagemPendente[x]) {
                    int tempoResposta = tempoAtual - pendentes[x];
                    temposResposta[x] += tempoResposta;
                    temMensagemPendente[x] = false; // mensagem respondida
                }
                tempoAtual++;
            } else if (tipo == 'T') {
                //avançar o tempo em x segundos
                tempoAtual += x -1; //como o tempo já avança em 1 por padrão, subtraímos 1
            }
        }
        //amigos que ainda possuem mensagens sem resposta recebem tempo -1
        for (int i = 0; i < 101; i++) {
            if (temMensagemPendente[i]) {
                temposResposta[i] = -1;
            }
        }
        //exibição da saída ordenada pelos números dos amigos
        for (int i = 0; i < 101; i++) {
            if (temposResposta[i] != 0) {
                Console.WriteLine(i + " " + temposResposta[i]);
            }
        }
    }
}