namespace tabuleiro {
    abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qteMovimentos = 0;
        }
        public void incrementarQuantidadeMovimentos() {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tabuleiro.linhas; i++) {
                for (int j = 0; j < tabuleiro.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao posicao) {
            return movimentosPossiveis()[posicao.linha, posicao.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
