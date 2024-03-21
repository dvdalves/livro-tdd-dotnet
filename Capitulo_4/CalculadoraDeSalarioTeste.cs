using NUnit.Framework;

namespace Capitulo_4
{
    [TestFixture]
    public class CalculadoraDeSalarioTeste
    {

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new();
            Funcionario desenvolvedor = new Funcionario("David", 1500.0, Cargo.Desenvolvedor);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }
        
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new();
            Funcionario desenvolvedor = new Funcionario("David", 4000.0, Cargo.Desenvolvedor);

            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }
    }
}