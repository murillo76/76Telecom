using System;
using System.Text;

namespace Aula1
{
    public class Chamado
    {
        public static string path { get; set;}
        public string RespostaChamado { get; }   
        
        public Chamado(int resposta)
        {
          switch(resposta)
          {
              case 1:
                RespostaChamado = Abertura();
                break;
              case 2:
                RespostaChamado = Fechamento();
                break;
          }
        }
        private static string Abertura()
        {
            StringBuilder myStringChamado = new StringBuilder();
            
            Console.Write("\nNome/Contato: ");
            string nome = Console.ReadLine();
            myStringChamado.Append("Nome / Contato: " + nome);

            Console.Write("\nTelefone para retorno: ");
            string telefone = Console.ReadLine();
            myStringChamado.Append("\n\nTelefone para retorno: " + telefone);

            Console.Write("\nIncidente / Solicitação:  ");
            string incidente = Console.ReadLine();
            myStringChamado.Append("\n\nIncidente / Solicitação:  " + incidente);

            Console.Write("\nChamado vinculado: ");
            string chamado = Console.ReadLine();
            myStringChamado.Append("\n\nChamado vinculado:  " + chamado);

            Console.Write("\nContrato: ");
            string Contrato = Console.ReadLine();
            myStringChamado.Append("\n\nContrato:  " + Contrato);

            Console.Write("\nObservações adicionais: ");
            string obs = Console.ReadLine();
            myStringChamado.Append("\n\nObservações adicionais:  " + obs);

            Console.WriteLine("\n\nGostaria de salvar teste de ping? S/N");
            
            string resposta = Console.ReadLine();

            if(resposta == "s" || resposta == "S")
            {
                Console.Write("\nIP: ");
                string ip = Console.ReadLine();
                Console.Write("\nPACOTES: ");
                int pacotes = int.Parse(Console.ReadLine());
                myStringChamado.Append("\n\nTeste de ping:\n\n" + ShellHelper.Ping(ip, pacotes));
            }
            return myStringChamado.ToString();
        }

        private string Fechamento()
        {
            StringBuilder myStringChamado = new StringBuilder();
            
            Console.WriteLine("\n- O que foi feito para resolver? ");
            string resolucao = Console.ReadLine();
            myStringChamado.Append("Diagnóstico da falha:\n\n- O que foi feito para resolver? \n" + resolucao);

            Console.WriteLine("\n- Qual o motivo do incidente? ");
            string incidente = Console.ReadLine();
            myStringChamado.Append("\n\n- Qual o motivo do incidente? \n" + incidente);

            Console.WriteLine("\n- Qual departamento resolveu?  ");
            string departamento = Console.ReadLine();
            myStringChamado.Append("\n\n- Qual departamento resolveu?  \n" + departamento);

            Console.WriteLine("\n- Houve necessidade de substituição de algum dispositivo instalado no cliente?  ");
            string dispositivo = Console.ReadLine();
            myStringChamado.Append("\n\n- Houve necessidade de substituição de algum dispositivo instalado no cliente?   \n" + dispositivo);

            Console.WriteLine("\n- O caso foi solucionado? Com quem foi homologado este caso? ");
            string homologado = Console.ReadLine();
            myStringChamado.Append("\n\n- O caso foi solucionado? Com quem foi homologado este caso?  \n" + homologado);

            return myStringChamado.ToString();
        }
    }
}