namespace EncontroRemoto8.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(texto);

            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.WriteLine(".");
                Thread.Sleep(tempo);
                
            }
            
            Console.ResetColor();
        }

        public static void VerificarPastaArquivo(string caminho){
            
            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                using(File.Create(caminho)){}
            }
        }
    }
}