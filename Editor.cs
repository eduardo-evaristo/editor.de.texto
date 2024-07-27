namespace EditorDeTexto
{
    internal class Editor
    {
        // O dicionário de palavras que o editor de texto vai usar.
        private Dicionario dicionario;

        // Construtor que recebe um dicionário e o associa ao editor de texto.
        public Editor(Dicionario dicionario)
        {
            this.dicionario = dicionario;
        }

        // Método principal que executa o editor de texto, recebe um objeto richTextBox, que é o campo visual de texto.
        public void ExecutarEditor(RichTextBox richTextBox)
        {
            string input = richTextBox.Text;

            // Seleciona e deixa pretas as palavras para atualizar as que possam ter sido alteradas.
            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;
            richTextBox.DeselectAll();

            //Divide o campo de texto em palavras individuais, baseado nos caracteres abaixo.
            var palavras = input.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            
            //Faz um loop por cada palavra contida na caixa de texto.
            foreach (var palavra in palavras)
            {
                //Se palavra não estiver dentro do dicionário.
                if (!dicionario.PesquisaDicionario(palavra))
                {
                    //Obtemos o início(índice) da palavra.
                    int startIndex = richTextBox.Find(palavra);
                    if (startIndex != -1)
                    {

                        // Seleciona e deixa em vermelho a palavra errada (que não está no dicionário).
                        richTextBox.Select(startIndex, palavra.Length);
                        richTextBox.SelectionColor = Color.Red;

                        // Assegura que o resto do texto não vai ficar vermelho (caso última palavra for errada).
                        richTextBox.SelectionStart = startIndex + palavra.Length;
                        richTextBox.SelectionLength = 0;
                        richTextBox.SelectionColor = Color.Black;
                    }
                }
            }
            //Envia o "cursor" para o final do texto pra continuar o fluxo de escrita.
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.SelectionLength = 0;
        }

        //Remove cor vermelha de palavra que foi adicionada ao dicionário.
        public void AtualizarCorDepoisDeAdicionar(RichTextBox richTextBox)
        {
            richTextBox.SelectionColor = Color.Black;
        }
    }
}
