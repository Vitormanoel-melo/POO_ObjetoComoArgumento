using System;
using ObjetoComoArgumento.Classes;

namespace ObjetoComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Read Dead Redemption", 499f);
            Produto p2 = new Produto(2, "GTA 5", 56.90f );
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f );
            Produto p4 = new Produto(4, "Celeste", 22.99f );

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProdutos();

            carrinho.MostrarTotal();
            // carrinho.RemoverProduto(p1);

            Produto p5 = new Produto(5, "GTA San Andreas", 120f);

            carrinho.AlterarItem(1, p5);

            carrinho.MostrarProdutos();
            carrinho.MostrarTotal();

        }
    }
}
