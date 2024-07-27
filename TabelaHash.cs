namespace EditorDeTexto
{
    internal class TabelaHash
    {
        // Classe interna que representa um nó na tabela hash.
        private class No
        {
            private string Chave;
            private No Proximo;

            public No(string chave)
            {
                Chave = chave;
                Proximo = null;
            }
            public String getChave() { return Chave; }
            public No getProx() { return Proximo; }
            public void setChave(String c) { Chave = c; }
            public void setProx(No p) { Proximo = p; }
        }

        private No[] tabela;
        private int tamanho;

        // Construtor que inicializa a tabela hash com um tamanho especificado.
        public TabelaHash(int tamanho)
        {
            this.tamanho = tamanho;
            tabela = new No[tamanho];
        }

        // Função hash que calcula o índice baseado na soma dos caracteres da chave.
        private int FuncaoHash(string chave)
        {
            int hash = 0;
            foreach (char c in chave)
            {
                hash += c;
            }
            return hash % tamanho;
        }

        // Adiciona uma chave à tabela hash.
        public void Adicionar(string chave)
        {
            int hash = FuncaoHash(chave);
            No novoNo = new No(chave);

            if (tabela[hash] == null)
            {
                tabela[hash] = novoNo;
            }
            else
            {
                No atual = tabela[hash];
                while (atual.getProx() != null && atual.getChave() != chave)
                {
                    atual = atual.getProx();
                }
                if (atual.getChave() != chave)
                {
                    atual.setProx(novoNo);
                }
            }
        }

        // Verifica se uma chave está presente na tabela hash.
        public bool Contem(string chave)
        {
            int hash = FuncaoHash(chave);
            No atual = tabela[hash];
            while (atual != null)
            {
                if (atual.getChave() == chave)
                {
                    return true;
                }
                atual = atual.getProx();
            }
            return false;
        }

        // Remove uma chave da tabela hash.
        public void Remover(string chave)
        {
            int hash = FuncaoHash(chave);
            No atual = tabela[hash];
            No anterior = null;

            while (atual != null)
            {
                if (atual.getChave() == chave)
                {
                    if (anterior == null)
                    {
                        tabela[hash] = atual.getProx();
                    }
                    else
                    {
                        anterior.setProx(atual.getProx());
                    }
                    return;
                }
                anterior = atual;
                atual = atual.getProx();
            }
        }

        // Imprime o conteúdo da tabela hash.
        public void ImprimirTabela()
        {
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Balde {i}: ");
                No atual = tabela[i];
                while (atual != null)
                {
                    Console.Write($"{atual.getChave()} ");
                    atual = atual.getProx();
                }
                Console.WriteLine();
            }
        }
    }
}
