namespace Calculadora_com_TDD.test;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3)]
    public void Test1(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora (); 

        int resultadoCalculadora = calc.Somar(num1,num2); 

        Assert.Equal(resultado,resultadoCalculadora); 
    }
}