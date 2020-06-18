namespace Aula20Ifood
{
    public class Pedido
    {
        public string itens { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaPGTO { get; set; }
        public bool PedidoPago { get; set; }

        public Pedido(string _itens, string _cliente, string _restaurante, string _formadepgto, bool _pedidopago)
        {
            this.itens = _itens;
            this.Cliente = _cliente;
            this.Restaurante = _restaurante;
            this.FormaPGTO = _formadepgto;
            this.PedidoPago = _pedidopago;
        }

        public string EntregarPedido(){
            if(PedidoPago == true){
                return "Pedido a caminho";
            }else{
                return "Falha ao Pedir";
            }

        }
    }
}