using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente kaua = new Cliente("Kaua Deja");
            kaua.EnderecoAtual = "Avenida Renata";
            restaurante BelaVista = new restaurante("Bela Vista","Rua Tecla 33");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = kaua;
            pedido1.restaurante = BelaVista;

            Console.WriteLine( pedido1.EntregarPedido() );


        }
    }
}
