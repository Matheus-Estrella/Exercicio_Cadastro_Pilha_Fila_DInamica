namespace Exercicio_Cadastro_Pilha_Fila_DInamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Fila fila = new Fila();
                Pilha pilha = new Pilha();
                for (int i = 0; i < 10; i++)
                {
                    fila.Push();
                    pilha.Push();
                }
                do
                {
                    Console.Write("\nEscolha uma das opções de impressão dos números sorteados\n" +
                        "1-) Imprimir Fila e Pilha\n2-) Imprimir Fila\n3-) Imprimir Pilha\n4-) Gerar novos números\n5-) Sair\n:");
                    op = Insert_Option(1, 5);
                    switch (op)
                    {
                        case 1:
                            Console.Write("\nOs elementos da fila são: ");
                            fila.Print();
                            Console.Write("\nOs elementos da pilha são: ");
                            pilha.Print();
                            Jump();

                            break;
                        case 2:
                            Console.Write("\nOs elementos da fila são: ");
                            fila.Print();
                            Jump();

                            break;
                        case 3:
                            Console.Write("\nOs elementos da pilha são: ");
                            pilha.Print();
                            Jump();
                            break;
                    }
                } while (op != 4 && op !=5);
                Jump();
            } while (op != 5);
        }
        static void Jump()
        {
            Console.WriteLine("\n\nDigite enter para continuar ...");
            Console.ReadKey();
            Console.Clear();
        }
        static int Insert_Option(int menor, int maior)
        {
            int i = 0;
            do
            {
                i = int.Parse(Console.ReadLine());
                if((i < menor || i > maior)){
                    Console.WriteLine("\nInsira uma opção válida");
                    Jump();
                }
            } while (i < menor || i > maior);
            return i;
        }
    }
}
