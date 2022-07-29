using FluentAssertions;
using Xunit;

namespace CharacterCounter.Test;

public class TestCharacterCounter
{    

        [Theory]
        [InlineData("", 1)]
        public void TestCharacterCounterSuccess(string text, int resultExpected)
        {
           throw new NotImplementedException();  
        }

        [Theory]
        [InlineData("")]
        public void TestCharacterCounterException(string text)
        {
           throw new NotImplementedException();  
        }
}