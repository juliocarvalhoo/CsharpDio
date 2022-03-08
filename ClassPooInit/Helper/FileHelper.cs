namespace ClassPooInit.Helper
{
    public class FileHelper
    {
        public void Listardiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }   
        }
        public void Listararquivos(string caminho)
        {
            var retornarArquivos = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);

            foreach (var retorno in retornarArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CreatedDirectory(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        
        public void DeleteDirectory(string caminho, bool deletar)
        {
            Directory.Delete(caminho,deletar);
        }

        public void CreatedFile(string caminho, string content)
        {
            if(!File.Exists(caminho))
            {
            File.WriteAllText(caminho,content);
            }
        }
    }
}