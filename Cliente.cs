namespace Aula20Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public Cliente(string _Nome){
            this.Nome = _Nome;
            
        }
        public string MostrarDados(){
            return $"Cliente:{Nome}, Endereço:{EnderecoAtual}";
        }




    }
}