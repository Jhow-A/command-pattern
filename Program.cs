namespace CommandPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new();

            var pedido = new Pedido(chef, OpcaoPedido.Prato);
            var garcom = new Garcom(pedido);
            garcom.Executar();

            pedido = new Pedido(chef, OpcaoPedido.Sobremesa);
            garcom = new Garcom(pedido);
            garcom.Executar();
        }
    }
}
