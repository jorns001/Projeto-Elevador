using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    class Elevador
    {
        /// <summary>
        /// Classe que contem as funções de cotrole do elevador
        /// </summary>
        public int nroAndares { get; set; }                 // o numero de andares no prédio (informado pelo usuário)
        public int capacidadeElevador { get; set; }         // a capacidade máxima do elevador (informado pelo usuário)
        public int pessoasNoElevador { get; set; }          // o número de pessoas no elevador (calculado)
        public int andarAtual { get; set; }                 // o andar onde o elevador se encontra (calculado)

        /// <summary>
        /// Método de inicialização da classe Elevador
        /// </summary>
        /// <param name="nroAndaresNoPredio"></param>
        /// <param name="nroMaxPessoasNoElevador"></param>
        public void Inicializar(int nroAndaresNoPredio, int nroMaxPessoasNoElevador)
        {
            nroAndares = nroAndaresNoPredio;
            capacidadeElevador = nroMaxPessoasNoElevador;
        }

        /// <summary>
        /// Método Informações: Mostra informações sobre a ocupação do elevador, o andar atual e o número de andares no prédio
        /// </summary>
        public void Informacoes()
        {
            Console.WriteLine("\t\t-----------------------------------------------");
            if (pessoasNoElevador == 0)
            {
                Console.WriteLine("\t\t\tNão ha nehuma pessoa no elevador");
            }
            else if (pessoasNoElevador < 2)
            {
                Console.WriteLine($"\t\t\tHá {pessoasNoElevador} pessoa no elevador");
            }
            else
            {
                Console.WriteLine($"\t\t\tHá {pessoasNoElevador} pessoas no elevador");
            }
            if (andarAtual > 0)
            {
                Console.WriteLine($"\t\t\tO elevador está no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine($"\t\t\tO elevador está no andar Térreo");
            }
            Console.WriteLine($"\t\t\tO Prédio tem {nroAndares} andares");
            Console.WriteLine("\t\t-----------------------------------------------");
            Console.WriteLine("\n\t\tTecle qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Método MostrarAndar: Mostra o número do andar onde está o  elevador
        /// </summary>
        private void MostrarAndar()
        {
            if (andarAtual > 0)
            {
                Console.WriteLine($"\t\tO elevador está no {andarAtual}º andar");
            }
            else
            {
                Console.WriteLine("\t\tO elevador está no Térreo");
            }
            Console.WriteLine("\t\tTecle qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Método SubirDescer: mostra a movimwntação do elevador
        /// </summary>
        /// <param name="andarAtual"></param>
        /// <param name="andarDestino"></param>
        /// <param name="direcao"></param>
        private static void SubirDescer(int andarAtual, int andarDestino, string direcao)
        {
            string upArrow = "\u25B2";
            string downArrow = "\u25BC";

            if (direcao == "up")
            {
                int andar = andarAtual;
                Console.Write($"\n\t{upArrow} - ");
                for (int i = andarAtual; i <= andarDestino; i++)
                {
                    Console.Write($"{i}º ");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            else if (direcao == "dn")
            {
                int andar = andarAtual;
                //Console.Write("\t\tDescendo: ");
                Console.Write($"\n\t{downArrow} - ");
                for (int i = andarAtual; i >= andarDestino; i--)
                {
                    Console.Write($"<{i}º> ");
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Método Entrar: permite a entrada se a lotação máxima não foi atingida.
        ///                Emite uma mensagem caso esteja lotado.
        /// </summary>
        public void Entrar()
        {
            if (pessoasNoElevador < capacidadeElevador)
            {
                pessoasNoElevador++;
                if (pessoasNoElevador > 1)
                {
                    Console.WriteLine($"\t\tHá {pessoasNoElevador} pessoas no elevador");
                }
                else
                {
                    Console.WriteLine($"\t\tHá {pessoasNoElevador} pessoa no elevador");
                } 
            }
            else
            {
                Console.WriteLine("\t\tElevador está com a capacidade máxima");
            }
            Console.Write("\n\n\t\tTecle qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Método Sair: retira pessoas do elevador, até não haver mais nenhuma.
        ///              emite uma mensagem caso o elevador esteja vazio
        /// </summary>
        public void Sair()
        {
            ///
            // Sair do elevador
            // Permite a saida de pessoas até que não reste nenhuma, emite um aviso se elevador vazio
            if (pessoasNoElevador > 0)
            {
                pessoasNoElevador--;
                if (pessoasNoElevador > 1)
                {
                    Console.WriteLine($"\t\tHá {pessoasNoElevador} pessoas no elevador");
                }
                else
                {
                    Console.WriteLine($"\t\tHá {pessoasNoElevador} pessoa no elevador");
                }
            }
            else
            {
                Console.WriteLine("\t\t\tNão há pessoas no elevador");
            }
            Console.Write("\n\n\t\t\tTecle qualquer tecla");
            Console.ReadKey();
        }

        /// <summary>
        /// Método Subir: sobe um andar se o elevador não estiver no último andar.
        ///               Emite uma mensagem se já estiver no último andar
        /// </summary>
        public void Subir()
        {
            if (andarAtual < nroAndares)
            {
                if (andarAtual < nroAndares)
                {
                    andarAtual++;
                    MostrarAndar();
                }
                else
                {
                    Console.WriteLine("ELevador já está no último andar");
                }
            }
            else
            {
                Console.WriteLine("\t\t\tElevador já está no último andar");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Método Descer: desce  um andar, se o elevador não estiver no Térreo
        ///                Emite uma mensagem caso o elevador esteja no Térreo
        /// </summary>
        public void Descer()
        {
            
            if (andarAtual > 0)
            {
                andarAtual--;
                MostrarAndar();
            }
            else
            {
                Console.WriteLine("\t\t\tElevador já está no Térreo");
                Console.WriteLine("\t\t\tTecle qualquer tecla");
                Console.ReadKey();
            }
        }
    }
}
