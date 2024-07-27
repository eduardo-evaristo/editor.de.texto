namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        // Declara��o de v�riavel tipo Dicion�rio no escopo global.
        private Dicionario dicionario;

        // Esse � o caminho onde est� o arquivo de dicion�rio.
        private string caminho = "C:\\Users\\eduardo\\source\\repos\\AED2\\EditorDeTexto\\EditorDeTexto\\dicionario.txt"; 
        //OBS: � necess�rio copiar o caminho absoluto para o arquivo "dicionario.txt".
        
        // Declara��o de v�riavel tipo Editor no escopo global.
        private Editor editor;
        
        // Declara��o de v�riavel Timer no escopo global.
        private System.Windows.Forms.Timer executionTimer;
        public Form1()
        {
            InitializeComponent();
            // Observador de eventos KeyDown pro richTextBox1.
            richTextBox1.KeyDown += new KeyEventHandler(RichTextBox1_KeyDown);
            
            // Instancia��o do objeto dicion�rio, com argumento caminho (dicion�rio).
            dicionario = new Dicionario(caminho);
           
            // Instancia��o do objeto editor, com argumento objeto dicion�rio.
            editor = new Editor(dicionario);

            // Instancia��o de objeto Timer.
            executionTimer = new System.Windows.Forms.Timer();
           
            //Coloca a propriedade Interval para 3 segundos.
            executionTimer.Interval = 3000;
           
            //Associando o evento Tick ao obsrrvador de eventos.
            executionTimer.Tick += ExecutionTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void fileToolStripMenuItem_Click(object sender, EventArgs e){}

        private void richTextBox1_TextChanged(object sender, EventArgs e){}

        private void fontDialog1_Apply(object sender, EventArgs e){}

        //Bot�o Novo.
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Limpa o campo.
            richTextBox1.Clear();
        }

        //Bot�o Abrir.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre di�logo de sele��o de arquivo.
            openFileDialog1.Title = "Selecione um arquivo de texto .txt";
            
            //N�o permite mais de um arquivo ser selecionado.
            openFileDialog1.Multiselect = false;
            
            //Especifica tipo de arquivo a ser aceito.
            openFileDialog1.Filter = "Text Files (.txt) | *.txt";
            
            //Se for apertado "Ok" no di�logo.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Instancia um objeto StreamReader que pega como argumento o nome do arquivo a ser aberto.
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
               
                //Torna o texto do campo de texto o conte�do do arquivo.
                richTextBox1.Text = sr.ReadToEnd();
               
                //Fecha o StreamReader.
                sr.Close();
            }
        }

        //Bot�o Salvar.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre o di�logo de salvamento de arquivos.
            saveFileDialog1.Title = "Salve o arquivo";
            
            //Especifica tipo a saer salvo.
            saveFileDialog1.Filter = "Text Files (.txt) | *.txt";
            
            //Se for apertado "Ok" no di�logo.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Instancia um objeto StreamWriter que pega como argumento o nome do arquivo salvo.
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
               
                //Escreve nele o conte�do do campo de texto.
                sw.Write(richTextBox1.Text);
               
                //Fecha o StreamWriter.
                sw.Close();
            }

        }

        //Bot�o Sair.
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sai da aplica��o.
            Application.Exit();
        }

        //Bot�o Selecionar Tudo.
        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seleciona tudo.
            richTextBox1.SelectAll();
        }

        //Bot�o Copiar.
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copia algo.
            richTextBox1.Copy();
        }

        //Bot�o Colar.
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cola algo.
            richTextBox1.Paste();
        }

        //Bot�o Recortar.
        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Recorta o texto.
            richTextBox1.Cut();
        }

        //Bot�o Validar.
        private void validarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Aqui o editor executa um forEach no richTextBox1, divide o texto em palavras e valida tudo.
            editor.ExecutarEditor(richTextBox1);
        }

        //Fun��o pra executar o m�todo que faz varredura toda vez que esse eventos de clique forem observados.
         private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Teclas aceitas
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Oemcomma ||
                e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.OemQuestion ||
                e.KeyCode == Keys.OemSemicolon ||
                (e.KeyCode == Keys.D1 && Control.ModifierKeys == Keys.Shift))
            {
                // Reinicia o timer, para valer apenas o �ltimo pressionar de teclas
                executionTimer.Stop();
                executionTimer.Start();
            }
        }

        //Fun��o para executar a varredura no texto automaticamente com base nos ticks.
        private void ExecutionTimer_Tick(object sender, EventArgs e)
        {
            // Para o timer pra ele n�o ser invocado mais de uma vez.
            executionTimer.Stop();

            // Chama o m�todo que faz a varredura no texto.
            editor.ExecutarEditor(richTextBox1);
        }

        //Bot�o p adicionar palavra ao dicion�rio.
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Palavra que vai ser adicionada no dicion�rio, o m�todo trim evita que a palavra v� com espa�os vazios anexados nela.
            string palavraASerdicionada = richTextBox1.SelectedText.Trim();
            
            //M�todo que a adiciona no dicion�rio.
            dicionario.AdicionarDicionario(palavraASerdicionada);
            
            //M�todo que remove a cor vermelha de palavras erradas ap�s serem adicionadas (se tiver).
            editor.AtualizarCorDepoisDeAdicionar(richTextBox1);
        }
    }
}
