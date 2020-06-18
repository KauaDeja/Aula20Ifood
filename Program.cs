using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Kaua Deja");
            Console.WriteLine(cliente.MostrarDados());
            

            restaurante restaurante = new restaurante("Bela Vista", "Avenida Renata 560");
            Console.WriteLine(restaurante.MostrarDados());
            
            
            Pedido pedido = new Pedido("Pizza Mussarela","Kaua","Bela Vista","Cartão-Debito");
        }
    }
}
