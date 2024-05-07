using Calculadora.Services;

namespace CalculadoraTestes;

public class UnitTest1
{
    private CalculadoraImp _calc;
    public UnitTest1()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        //Arrenge
        //Act
        int resultadoCalculadora = _calc.somar(val1, val2);
        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData(10, 2, 8)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        //Arrenge
        //Act
        int resultadoCalculadora = _calc.subtrair(val1, val2);
        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        //Arrenge
        //Act
        int resultadoCalculadora = _calc.multiplicar(val1, val2);
        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(10, 5, 2)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        //Arrenge
        //Act
        int resultadoCalculadora = _calc.dividir(val1, val2);
        //Assert
        Assert.Equal(resultado, resultadoCalculadora);

    }
    [Fact]
    public void TestarHistorico()
    {

        _calc.somar(1, 2);
        _calc.somar(2, 8);
        _calc.somar(3, 7);
        _calc.somar(4, 1);

        var lista = _calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}