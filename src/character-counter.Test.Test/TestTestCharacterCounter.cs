using Xunit;
using FluentAssertions;

namespace CharacterCounter.Test.Test;

public class TestTestCharacterCounter1
{
    [Trait("Category", "1 - Criou testes para o TestCharacterCounterSuccess")]
    [Theory(DisplayName = "TestCharacterCounterSuccess deve ser executado com sucesso")] 
    [InlineData("O Rato Roeu a Roupa do Rei de Roma", 34)]
    [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe", 49)]
    [InlineData("Teste Unitário é muito massa!", 29)]  
    public void TestSuccessTestCharacterCounterSuccess(string text, int resultExpected)
    {   
        var testClass = new TestCharacterCounter();
        Action act = () => testClass.TestCharacterCounterSuccess(text, resultExpected);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    } 

    [Trait("Category", "1 - Criou testes para o TestCharacterCounterSuccess")]
    [Theory(DisplayName = "TestCharacterCounterSuccess deve falhar com input de falha")] 
    [InlineData("O Rato Roeu a Roupa do Rei de Roma", 40)]
    [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe", 31)]
    [InlineData("Teste Unitário é muito massa!", 15)]  
    public void TestFailTestCharacterCounterSuccess(string text, int resultUnexpected)
    {          
        var testClass = new TestCharacterCounter();
        Action act = () => testClass.TestCharacterCounterSuccess(text, resultUnexpected);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

public class TestTestCharacterCounter2 
{
    [Trait("Category", "2 - Criou testes para o TestCharacterCounterException")]
    [Theory(DisplayName = "TestCharacterCounterException deve ser executado com sucesso com input de falha")] 
    [InlineData(null)]
    public void TestSuccessTestCalculateShippingException(string text)
    {   
        var testClass = new TestCharacterCounter();
        Action act = () => testClass.TestCharacterCounterException(text);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - Criou testes para o TestCharacterCounterException")]
    [Theory(DisplayName = "TestCharacterCounterException deve falhar com input de sucesso")] 
    [InlineData("O Rato Roeu a Roupa do Rei de Roma")]
    [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe")]
    [InlineData("Teste Unitário é muito massa!")]  
    public void TestFailTestCharacterCounterException(string text)
    {   
        var testClass = new TestCharacterCounter();
        Action act = () => testClass.TestCharacterCounterException(text);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
