
using System;

namespace CommandPattern
{
    // Concrete Command
    public class Pedido : ICommand
    {
        private Chef Chef { get; }
        private OpcaoPedido Acao { get; }

        public Pedido(Chef chef, OpcaoPedido acao)
        {
            Chef = chef;
            Acao = acao;
        }

        public void Execute()
        {
            if (Acao.Equals(OpcaoPedido.Prato))
                Chef.PrepararPrato();

            else if (Acao.Equals(OpcaoPedido.Sobremesa))
                Chef.PrepararSobremesa();

            else
                throw new Exception("Erro ao obter pedido!");
        }
    }
}
