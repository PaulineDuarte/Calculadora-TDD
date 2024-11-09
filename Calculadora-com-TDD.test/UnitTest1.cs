namespace Calculadora_com_TDD.test;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,6)]
    public void TestSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora (); 

        int resultadoCalculadora = calc.Somar(num1,num2); 

        Assert.Equal(resultado,resultadoCalculadora); 
    }

    [Theory]
    [InlineData(6,2,4)]
    [InlineData(5,5,0)]
    public void TestSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora (); 

        int resultadoCalculadora = calc.Subtrair(num1,num2); 

        Assert.Equal(resultado,resultadoCalculadora); 
    }
    [Theory]
    [InlineData(1,2,2)]
    [InlineData(4,5,20)]

    public void TestMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora (); 

        int resultadoCalculadora = calc.Multiplicar(num1,num2); 

        Assert.Equal(resultado,resultadoCalculadora); 
    }

    [Theory]
    [InlineData(6,2,3)]
    [InlineData(5,5,1)]
     public void TestDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora (); 

        int resultadoCalculadora = calc.Dividir(num1,num2); 

        Assert.Equal(resultado,resultadoCalculadora); 
    }

    [Fact]
    public void TestarDividirPorZero()
    {
        Calculadora calc = new Calculadora(); 

        Assert.Throws<DivideByZeroException>(()=>calc.Dividir(3,0));
    }

     [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new Calculadora(); 

        calc.Somar(1,2);
        calc.Somar(4,8);
        calc.Somar(3,5);
        calc.Somar(6,6);

        var lista = calc.historico();
        // Não pode retornar vazio
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}