using ProjetoTdd.Models;

namespace ProjetoTddTests
 
{
    public class UnitTest1
    {
        public Calculadora contruirClasse()
        {
            string data = "31/10/2023";
            Calculadora calc = new Calculadora("31/10/2023");

            return calc;
        }


        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(6, 7, 13)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(10, 3, 7)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(6, 7, 42)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(2, 1, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = contruirClasse();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact] 
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = contruirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void Historico()
        {
            Calculadora calc = contruirClasse();

            calc.Somar(1,2);
            calc.Somar(2,8);
            calc.Somar(3,7);
            calc.Somar(4,1);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}