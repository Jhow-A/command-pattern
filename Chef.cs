using System;

namespace CommandPattern
{
    // Receiver
    public class Chef
    {
        public void PrepararPrato() =>
            Console.WriteLine("Chef esta preparando o prato: Frango Marinado com especiarias.\n");

        public void PrepararSobremesa() =>
            Console.WriteLine("Chef esta preparando a sobremesa: Petit Gateau.\n");

    }
}
