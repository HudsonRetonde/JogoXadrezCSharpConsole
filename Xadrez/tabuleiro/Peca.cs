using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro;

internal class Peca
{
	public Posicao posicao { get; set; }
	public Cor cor { get; set; }
	public int qteMovimentos { get; protected set; }
	public Tabuleiro tab { get; protected set; }

	public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
	{
		this.posicao = posicao;
		this.tab = tab;
		this.cor = cor;
		this.qteMovimentos = 0;
	}
}
