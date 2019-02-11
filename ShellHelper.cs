using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

    public class ShellHelper
    {
    private static string ping = "";
    public static string Ping(string ip, int pacotes)
    {
        BashToClip("ping",$"-c {pacotes} {ip}");
        return ping;
    }
    public static void CopiarChamado(string myStringChamado, string path)
    {
        BashToClip($"xclip", "-selection clipboard " + path, myStringChamado);
    }
     private static void BashToClip(string CommandShell, string ArgumentShell, string TextCopy = "opcional")
    {
        var psi = new ProcessStartInfo
        {
            FileName = CommandShell,
            Arguments = ArgumentShell,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        var proc = new Process
        {
            StartInfo = psi
        };

        proc.Start();

    if(CommandShell == "ping")
    {
        Task.WaitAll(Task.Run(() =>
         {
             while (!proc.StandardOutput.EndOfStream)
             {
                 var line = proc.StandardOutput.ReadLine();
                 Console.WriteLine(line);
                 ping += line.ToString();
                 
            }
            
         }), Task.Run(() =>
            {
             while (!proc.StandardError.EndOfStream)
             {
                 var line = proc.StandardError.ReadLine();
                 Console.WriteLine(line);
                 ping += line.ToString();
             }
         }));
    }

    
            proc.WaitForExit();
            if(proc.ExitCode == 0 && CommandShell == "ping")
            {
                Console.WriteLine("\nIP Gerado no encerramento");
            }
            else if(proc.ExitCode == 0)
            {
                Console.WriteLine("\nCopiado para área de transferência");
                File.Delete("chamado.txt");
            }
            if(File.Exists("encerramento.txt"))
            {
                File.Delete("encerramento.txt");
            }
            
            
        }
    }