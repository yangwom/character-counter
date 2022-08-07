using FluentAssertions;
using Xunit;

namespace CharacterCounter.Test;

public class TestCharacterCounter
{

    [Theory]
    [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe", 49)]
    public void TestCharacterCounterSuccess(string text, int resultExpected)
    {
        var StaticChar = CharacterCounter.Action(text);

        StaticChar.Should().Be(resultExpected);
    }

    [Theory]
    [InlineData("")]
    public void TestCharacterCounterException(string text)
    {
        Action act = () => CharacterCounter.Action(text);
        act.Should().Throw<Exception>().WithMessage("O valor não pode ser nulo");
    }
}