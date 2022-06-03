using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotAbrirSoftware.Helper
{
    public static class Configuracao
    {
        public static int intervaloMinuto { get; private set; }
        public static int emuladorSimultaneo { get; private set; }
        public static string pathBlueStacks { get; private set; }

      

        private static string path = System.IO.Directory.GetCurrentDirectory() + "\\Config.txt";
        public static void Informacoes()
        {
            string[] conteudo;
            bool Erro = false;
            try
            {
                conteudo = File.ReadAllLines(path);
                int v1 = int.Parse(conteudo[0].Replace("Intervalo de Minutos=", ""));
                int v2 = int.Parse(conteudo[1].Replace("Emuladores Simultâneos=", ""));
                string v3 = conteudo[2].Replace("Caminho BlueStacks=", "");
                intervaloMinuto = v1;
                emuladorSimultaneo = v2;
                pathBlueStacks = v3;
            }
            catch
            {
                Erro = true;
            }
            if (Erro)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                intervaloMinuto = 1;
                emuladorSimultaneo = 1;
                pathBlueStacks = @"C:\Program Files\BlueStacks_nxt\HD-Player.exe";
                Create(path, intervaloMinuto, emuladorSimultaneo, pathBlueStacks);
               
            }
        }
        public static void Atualizar(int intervaloMinutoLocal, int emuladorSimultaneoLocal, string pathBlueStacksLocal)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Create(path, intervaloMinutoLocal, emuladorSimultaneoLocal, pathBlueStacksLocal);
            intervaloMinuto = intervaloMinutoLocal;
            emuladorSimultaneo = emuladorSimultaneoLocal;
            pathBlueStacks = pathBlueStacksLocal;

        }
        private static void Create(string pathLocal, int intervaloMinutoLocal, int emuladorSimultaneoLocal, string pathBlueStacksLocal)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter streamWriter = File.CreateText(pathLocal))
            {
                streamWriter.WriteLine("Intervalo de Minutos=" + intervaloMinutoLocal);
                streamWriter.WriteLine("Emuladores Simultâneos=" + emuladorSimultaneoLocal);
                streamWriter.WriteLine("Caminho BlueStacks=" + pathBlueStacksLocal);
                streamWriter.Close();
            }
        }
    }
}
