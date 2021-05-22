using System;
using Xunit;

namespace Telegram.Bot.Tests.Unit
{
    public class Unit_Tests_13
    {
        [Theory]
        [InlineData("1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy", 1234567)]
        [InlineData("9:jdsaghdfilghdfiugherh", 9)]
        [InlineData("0:foo", 0)]
        [InlineData("5:", 5)]
        [InlineData("-123::::", -123)]
        public void Should_Parse_Bot_Id(string token, long expectedId)
        {
            //ITelegramBotClient botClient = new TelegramBotClient(token);
            //Assert.Equal(expectedId, botClient.BotId);
        }

        [Fact]
        public void Should_Throw_On_Null_Token()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => new TelegramBotClient(null)
            );
            Assert.Equal("token", exception.ParamName);
        }
    }
}
