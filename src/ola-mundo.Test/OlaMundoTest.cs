using ola_mundo;
using System.IO;
using Xunit;
using System;

namespace ola_mundo.Test;

public class OlaMundoTest
{
    [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
    [InlineData("<Insira algo aqui>")]
    public void TestOlaMundo(string Expected)
    {
        throw new NotImplementedException();
    }
}
