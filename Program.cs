using System;

namespace teste_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var produto = new Produto();
            while (string.IsNullOrWhiteSpace(produto.descricao))
            {
                Console.WriteLine("Digite a descricao do produto: ");
                produto.descricao = Console.ReadLine();
            }

            decimal _preco = 0;
            produto.precoUnitario = 0;
            Console.WriteLine("Digite o preco unitario do produto: ");
            while (produto.precoUnitario == 0)
            {
                string entradaPreco = Console.ReadLine();
                if (decimal.TryParse(entradaPreco, out _preco))
                    produto.precoUnitario = _preco;
                else
                    Console.WriteLine("Preco unitario invalido. Redigite: ");
            }

            var compra = new Compra();
            int _quantidade = 0;
            compra.quantidade = 0;
            compra.produto = produto;
            Console.WriteLine("Digite a quantidade adquirida do produto: ");
            while (_quantidade == 0)
            {
                string entradaQuantidade = Console.ReadLine();
                if (int.TryParse(entradaQuantidade, out _quantidade))
                    compra.quantidade = _quantidade;
                else
                    Console.WriteLine("Quantidade informada invalida. Redigite: ");

            }
            Console.WriteLine($@"Preco Total de {compra.quantidade} unid. de {produto.descricao} ao preco de {(compra.quantidade * produto.precoUnitario).ToString("C2")}");
            Console.WriteLine($@"Preco com Desconto de {(1 - compra.Desconto).ToString("P")} para {compra.quantidade} unid. de {produto.descricao} ao preco de {(compra.Desconto * compra.quantidade * produto.precoUnitario).ToString("C2")}");
        }
    }
}
