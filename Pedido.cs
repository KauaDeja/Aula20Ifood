using System;

namespace Aula20Ifood
{
    public class Pedido
    {
        public string itens { get; set; }
        public Cliente Cliente { get; set; }
        public restaurante restaurante { get; set; }
        public string FormaPGTO { get; set; }
        public bool PedidoPago { get; set; }
        public DateTime DataEntrega { get; set; }   

        public string EntregarPedido(){
            DataEntrega = DateTime.Now;

            string retorno = "Pedido entregue! \n";
            retorno += restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();
            retorno += DataEntrega;

            return retorno;
        }

       
    }
}