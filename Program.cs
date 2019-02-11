using System;
using System.IO;
using System.Text;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"-------------------------------------------------------------------------------
|                                                                             |
|                             ########   #######                              |
|                             ##    ##  ##     ##                             |
|                                  ##   ##                                    |
|                                 ##    ########                              |
|                                ##     ##     ##                             |
|                                ##     ##     ##                             |
|                                ##      #######                              |
|       ######## ######## ##       ########  ######   #######  ##     ##      |
|          ##    ##       ##       ##       ##    ## ##     ## ###   ###      |
|          ##    ##       ##       ##       ##       ##     ## #### ####      |
|          ##    ######   ##       ######   ##       ##     ## ## ### ##      |
|          ##    ##       ##       ##       ##       ##     ## ##     ##      |
|          ##    ##       ##       ##       ##    ## ##     ## ##     ##      |
|          ##    ######## ######## ########  ######   #######  ##     ##      |
|                      ABERTURA / ENCERRAMENTO DE CHAMADO                     |
-------------------------------------------------------------------------------
");
            Console.Write("\n1 - Abrir chamado \n2 - Encerrar chamado\nDigite: ");
            int resposta = int.Parse(Console.ReadLine());
            Console.Clear();
            Chamado chamado = new Chamado(resposta);
            Console.Clear();
            string myStringChamado = chamado.RespostaChamado;

            Console.Clear();
            Arquivo.GerarArquivo(myStringChamado.ToString(), resposta);
            ShellHelper.CopiarChamado(myStringChamado.ToString(), Chamado.path);

        }
        
    }
}
