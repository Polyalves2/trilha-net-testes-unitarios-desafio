<<<<<<< HEAD
=======


>>>>>>> 4335808c953dd878e84f85453160b3747a426222
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
<<<<<<< HEAD
        Assert.Equal(resultadoEsperado, resultado);
=======
        Assert.Equal(resultado, resultadoEsperado);
>>>>>>> 4335808c953dd878e84f85453160b3747a426222
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado,numeroParaProcurar);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
<<<<<<< HEAD
         Assert.False(resultado);
=======
        Assert.False(resultado,numeroParaProcurar);
>>>>>>> 4335808c953dd878e84f85453160b3747a426222
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
         var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);


        // Assert
<<<<<<< HEAD
        Assert.Equal(resultadoEsperado, resultado);
=======
        Assert.Equal(resultado, resultadoEsperado);
>>>>>>> 4335808c953dd878e84f85453160b3747a426222
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(-8, resultado);
    }
}
<<<<<<< HEAD









// using Xunit;

// using TestesUnitarios.Desafio.Console.Services;

// namespace TestesUnitarios.Desafio.Tests;

// public class ValidacoesListaTests
// {
//     private ValidacoesLista _validacoes = new ValidacoesLista();

//     [Fact]
//     public void RemoverNumerosNegativosDeUmaLista()
//     {
//         // Arrange
//         var lista = new List<int> { 5, -1, -8, 9 };
//         var resultadoEsperado = new List<int> { 5, 9 };

//         // Act
//         var resultado = _validacoes.RemoverNumerosNegativos(lista);

//         // Assert
//         Assert.Equal(resultadoEsperado, resultado);
//     }

//     public List<int> RemoverNumerosNegativos(List<int> lista)
//     {
//         return lista.Where(x => x >= 0).ToList();
//     }

//     [Fact]
//     public void DeveConterONumero9NaLista()
//     {
//         // Arrange
//         var lista = new List<int> { 5, -1, -8, 9 };
//         var numeroParaProcurar = 9;

//         // Act
//         var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

//         // Assert
//         Assert.True(resultado);
//     }

//     [Fact]
//     public void NaoDeveConterONumero10NaLista()
//     {
//         //TODO: Implementar método de teste

//         // Arrange
//         var lista = new List<int> { 5, -1, -8, 9 };
//         var numeroParaProcurar = 10;

//         // Act
//         var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

//         // Assert
//         Assert.False(resultado);
//     }

//     //TODO: Corrigir a anotação [Fact]
//     public void DeveMultiplicarOsElementosDaListaPor2()
//     {
//         //TODO: Implementar método de teste

//         // Arrange
//         var lista = new List<int> { 5, 7, 8, 9 };
//         var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

//         // Act
//         var resultado = _validacoes.MultiplicarElementosPor2(lista);

//         // Assert
//         Assert.Equal(resultadoEsperado, resultado);
//     }

// }

// [Fact]
// public void DeveRetornar9ComoMaiorNumeroDaLista()
// {
//     //TODO: Implementar método de teste

//     // Arrange
//     var lista = new List<int> { 5, -1, -8, 9 };

//     // Act
//     var resultado = _validacoes.ObterMaiorNumero(lista);

//     // Assert
//     //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
//     Assert.Equal(9, resultado);
// }

// [Fact]
// public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
// {
//     //TODO: Implementar método de teste

//     // Arrange
//     var lista = new List<int> { 5, -1, -8, 9 };

//     // Act
//     var resultado = _validacoes.RetornarMenorNumeroLista(lista);

//     // Assert
//     //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
//     Assert.Equal(-8, resultado);
// }

=======
>>>>>>> 4335808c953dd878e84f85453160b3747a426222
