using System;
using System.IO;
using System.Text;

namespace Aula1
{
    public class Arquivo
    {
        private const string path = "chamado.txt";
        private const string path2 = "chamados.txt";
        private const string path3 = "encerramento.txt";
        public static void GerarArquivo(string myStringChamado, int resposta)
        {
            switch(resposta)
            {
                 case 1:
                    GerarAbertura(myStringChamado);
                    Chamado.path = "chamado.txt";
                    break;
                case 2:
                    GerarEncerramento(myStringChamado);
                    Chamado.path = "encerramento.txt";
                    break;
                default:
                    break;
            }
            
        }

        private static void GerarEncerramento(string myStringChamado)
        {
            try
            {
                if (!File.Exists(path3))
                {
                    using (FileStream fluxoArquivo = new FileStream(path3, FileMode.CreateNew))
                    {

                    }
                }

                using (FileStream fluxoArquivo = new FileStream(path3, FileMode.Open))
                using (var escritor = new StreamWriter(fluxoArquivo, Encoding.UTF8))
                {
                    escritor.Write(myStringChamado);
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static void GerarAbertura(string myStringChamado)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fluxoArquivo = new FileStream(path, FileMode.CreateNew))
                    {

                    }
                }

                using (FileStream fluxoArquivo = new FileStream(path, FileMode.Open))
                using (var escritor = new StreamWriter(fluxoArquivo, Encoding.UTF8))
                {
                    escritor.Write(myStringChamado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        // CHAMADOS.TXT
            try
            {
                if (!File.Exists(path2))
                {
                    using (FileStream fluxoArquivo = new FileStream(path2, FileMode.CreateNew))
                    {

                    }
                }

                using (FileStream fluxoArquivo = new FileStream(path2, FileMode.Open))
                using (StreamWriter escritor = File.AppendText(path2))
                {
                    escritor.WriteLine(myStringChamado + "\n\n" + DateTime.UtcNow +"====================================");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}