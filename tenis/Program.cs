using System;
class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Tirar esse prompt antes de mandar para o verde");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int[] vencedores = Resultados();
            int[] grupos = ClassificarJogadores(vencedores);
            ImprimirResultados(vencedores, grupos);
        }
    }
    public static int[] Resultados() {
        int[] vencedores = new int[15];
        for (int i = 0; i < 15; i++) {
            string[] entrada = Console.ReadLine().Split(' ');
            vencedores[i] = int.Parse(entrada[2]);
        }
        return vencedores;
    }
    public static int[] ClassificarJogadores(int[] vencedores) {
        int j1 = 0, j2 = 0, j3 = 0, j4 = 0, j5 = 0, j6 = 0;
        for (int i = 0; i < vencedores.Length; i++) {
            switch(vencedores[i]) {
                case 1:
                j1++;
                break;
                case 2:
                j2++;
                break;
                case 3:
                j3++;
                break;
                case 4:
                j4++;
                break;
                case 5:
                j5++;
                break;
                case 6:
                j6++;
                break;
            }
        }
        int[] vetor = new int[6] {
            j1, j2, j3, j4, j5, j6
        };
        for (int i = 0; i < vetor.Length; i++) {
            if (vetor[i] > 4)
            vetor[i] = 1;
            else if (vetor[i] == 3 || vetor[i] == 4)
            vetor[i] = 2;
            else if (vetor[i] == 1 || vetor[i] == 2)
            vetor[i] = 3;
            else
            vetor[i] = -1;
        }
        return vetor;
    }
    public static void ImprimirResultados(int[] vencedores, int[] grupos) {
        for (int i = 0; i < grupos.Length; i++) {
            Console.WriteLine($"{vencedores[i]} {grupos[i]}");
        }
    }
}