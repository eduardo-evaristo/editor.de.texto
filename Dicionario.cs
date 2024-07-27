namespace EditorDeTexto
{
    internal class Dicionario
    {
        // Esta é a tabela hash que usamos para armazenar as palavras.
        private TabelaHash dicionario;
        // Este é o caminho do arquivo onde as palavras estão armazenadas.
        private string caminhoDiretorio;

        // Construtor que inicializa a tabela hash e carrega as palavras do arquivo.
        public Dicionario(string caminho)
        {
            caminhoDiretorio = caminho;
            dicionario = new TabelaHash(100000);
            CarregarDicionario();
        }

        // Carrega as palavras do arquivo para a tabela hash.
        private void CarregarDicionario()
        {
            // Verifica se o arquivo existe antes de tentar carregar.
            if (File.Exists(caminhoDiretorio))
            {
                // Lê todas as linhas do arquivo.
                var lines = File.ReadAllLines(caminhoDiretorio);

                // Adiciona cada linha (palavra) à tabela hash, removendo espaços em branco e convertendo para minúsculas.
                foreach (var line in lines)
                {
                    dicionario.Adicionar(line.Trim().ToLower());
                }
            }
        }

        // Verifica se uma palavra está presente no dicionário.
        public bool PesquisaDicionario(string palavra)
        {
            return dicionario.Contem(palavra.ToLower());
        }

        // Adiciona uma nova palavra ao dicionário e ao arquivo, se ainda não estiver presente.
        public void AdicionarDicionario(string palavra)
        {
            // Só adiciona a palavra se ela ainda não estiver no dicionário.
            if (!PesquisaDicionario(palavra))
            {
                // Adiciona a palavra ao arquivo, garantindo que ela seja convertida para letras minúsculas.
                dicionario.Adicionar(palavra.ToLower());
                File.AppendAllText(caminhoDiretorio, palavra.ToLower() + Environment.NewLine);
                //Atualiza pra dicionário novo (com palavra nova).
            }
        }
    }
}
