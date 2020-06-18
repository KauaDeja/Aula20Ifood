namespace Aula20Ifood
{
    public class restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public restaurante(string _NomeRestaurante, string _Endereco){
            this.NomeRestaurante = _NomeRestaurante;
            this.Endereco = _Endereco;
        }

        public string MostrarDados(){
            return $"Nome Restaurante:{NomeRestaurante} Endereço:{Endereco}";
        }
    }
}