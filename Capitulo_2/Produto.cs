namespace Capitulo_2
{
    public class Produto
    {
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
