namespace Capitulo_4
{
    public class Funcionario
    {
        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Cargo Cargo { get; private set; }
    }

    public enum Cargo
    {
        Desenvolvedor,
        DBA,
        Testador
    }
}
