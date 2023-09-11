namespace Projeto_final_bloco_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opção = 1;

            while (opção != 6)
            {

                Console.WriteLine("*****************************************************");
                Console.WriteLine("                    Loja De Jogos do Vitor                                 ");
                Console.WriteLine("*****************************************************");

                Console.WriteLine(" 1 - Criar Jogo");
                Console.WriteLine(" 2 - Listar Todos os Jogos");
                Console.WriteLine(" 3 - Buscar jogo Pelo Número");
                Console.WriteLine(" 4 - Atualizar jogos ");
                Console.WriteLine(" 5 - Apagar jogos");
                Console.WriteLine(" 6 - Sair");

                Console.WriteLine("*****************************************************");
                Console.WriteLine("                  Digite a Sua Opção                 ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                opção = Convert.ToInt32(Console.ReadLine());

                if (opção == 6)
                {
                    Console.WriteLine("\nValeu e até mais");
                    System.Environment.Exit(0);
                }
            }
            switch (opção)
            {
                case 1:
                    Console.WriteLine("Crie o seu jogo");
                    break;
                case 2:
                    Console.WriteLine("Liste os seus jogos");
                    break;
                case 3:
                    Console.WriteLine("Buscar jogos pelo numero");
                    break;
                case 4:
                    Console.WriteLine("Atulizar lista de jogos");
                    break;
                case 5:
                    Console.WriteLine("Apagar os Jogos");
                    break;
            }
        }
    }
}