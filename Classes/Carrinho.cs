using System;
using System.Collections.Generic;

namespace ObjetoComoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal{get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }

        public void MostrarProdutos(){
            if(carrinho != null){

                foreach (Produto item in carrinho)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco} ");
                    Console.ResetColor();

                }

                // MostrarProdutos();
            }
        }

        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }    


        public void MostrarTotal(){
            ValorTotal = 0;
            if(carrinho != null){
                foreach (var item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"Valor total do carrinho: R${ValorTotal}");
            }
            else{
                Console.WriteLine("Seu carrinho está vazio!");
            }
        }

        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
            
        }


    }
}