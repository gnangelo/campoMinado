using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            Console.WriteLine("\n");

            string percorreCampo = campoMinado.Tabuleiro;

            
            for (var i = 0; i <= percorreCampo.Length; i++)
            {
                for (var j = 0; j <= percorreCampo.Length; j++)
                {
                    if (i == 4 && j == 1)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 5 && j == 2)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 5 && j == 3)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 5 && j == 6)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 6 && j == 1)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 6 && j == 7)
                    {
                        campoMinado.Abrir(i, j);
                    }

                    if (i == 6 && j == 9)
                    {
                        campoMinado.Abrir(i, j);
                    }
                }
            }
            Console.WriteLine(campoMinado.Tabuleiro);

            Console.WriteLine();

            if (campoMinado.JogoStatus == 0)
            {
                Console.WriteLine("Aberto!!!");
            }
            else if (campoMinado.JogoStatus == 1)
            {
                Console.WriteLine("Vitória!!!");
            }
            else
            {
                Console.WriteLine("GemeOver!!!");
            }
            Console.WriteLine("\n");

        }
    }
}
