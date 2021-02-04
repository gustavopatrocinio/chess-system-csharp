using tabuleiro;

namespace xadrez {

    class Bispo : Peca {

        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "B";
        }

        private bool podeMover(Posicao posicao) {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicao = new Posicao(0, 0);

            // NO
            posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor) {
                    break;
                }
                posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);
            }

            // NE
            posicao.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor) {
                    break;
                }
                posicao.definirValores(posicao.linha - 1, posicao.coluna + 1);
            }

            // SE
            posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor) {
                    break;
                }
                posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);
            }

            // SO
            posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao)) {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor) {
                    break;
                }
                posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);
            }

            return mat;
        }
    }
}