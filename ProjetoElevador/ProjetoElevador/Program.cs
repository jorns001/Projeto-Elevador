using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroAndares = 0;
            int capacidadeElevador = 0;
            string versaoSw = "1.0.2";
            char opcUsuario = 'x';

            Console.Clear();
            Console.WriteLine($"\n\t\tPrograma Gerenciador de Elevador versão {versaoSw}");
            Console.WriteLine("\t------------------------------------------------------------");
            // pede a quantidade de andares no prédio e a capacidade do elevador
            Console.Write("\tQual o número de andares do prédio? ");
            nroAndares = int.Parse(Console.ReadLine());
            Console.Write("\tQual a capacidade máxima do elevador? ");
            capacidadeElevador = int.Parse(Console.ReadLine());

            Elevador elevador = new Elevador();
            elevador.Inicializar(nroAndares, capacidadeElevador);
            Console.WriteLine("\t------------------------------------------------------------");
            while (opcUsuario != 'F')
            {
                Console.Clear();
                Console.WriteLine($"\n\t\tPrograma Gerenciador de Elevador versão {versaoSw}");
                Console.WriteLine("\t------------------------------------------------------------");
                // Exibe o menu de opções disponíveis ao usuário
                Console.WriteLine(@"
                               Opções
                             -------------------------
                             <E> Entrar
                             <S> Sair
                             <U> Subir
                             <D> Descer  

                             <I> Painel de informações
                             <F> Finalizar programa
                            --------------------------
                              ");
                Console.Write("\t\t\t\tEscolha uma opção: ");
                opcUsuario = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\n");
                // Escolhe a ação a ser adotada de acordo com a escolha do usuário
                switch (opcUsuario)
                {
                    case 'E':
                        {
                            Console.WriteLine("\t\tEntrar no elevador"); 
                            elevador.Entrar(); 
                            break;
                        }
                    case 'S':
                        {
                            Console.WriteLine("\t\tSair do elevador");
                            elevador.Sair();
                            break;
                        }
                    case 'U':
                        {
                            Console.WriteLine("\t\tSubir");
                            elevador.Subir();
                            break;
                        }
                    case 'D':
                        {
                            Console.WriteLine("\t\tDescer");
                            elevador.Descer();
                            break;
                        }
                    case 'F':
                        {
                            Console.WriteLine("\t\tFinalizar o programa");
                            break;
                        }
                    case 'I':
                        {
                            Console.WriteLine("\t\t\tPainel de informações");
                            elevador.Informacoes();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"\t\t\t\tOpção inválida <{opcUsuario}>");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}