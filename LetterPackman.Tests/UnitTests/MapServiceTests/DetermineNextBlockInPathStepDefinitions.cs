using Autofac.Extras.Moq;
using FluentAssertions;
using LetterPackman.Models;
using LetterPackman.Services;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace UnitTests.MapServiceTests
{
	[Binding]
    [Scope(Feature = "DetermineNextBlockInPath")]
    public class DetermineNextBlockInPathStepDefinitions
    {
        private GameMap gameMap;
        private char? previousBlock;
        private char? currentBlock;
        private GameMapBlock? result;
        private Exception? actualException;

        private readonly AutoMock mock;
        private readonly ISpecFlowOutputHelper outputHelper;

        public DetermineNextBlockInPathStepDefinitions(ISpecFlowOutputHelper outputHelper)
        {
            mock = AutoMock.GetStrict();
            this.outputHelper = outputHelper;
        }

        [Given(@"I have a map")]
        public void GivenIHaveAMap(Table table)
        {
            string[][] stringMap = table.Rows.Select(r => r.Values.ToArray()).ToArray();
            gameMap = new GameMap(stringMap);
        }

		[Given(@"previous block is: (.*)")]
		public void GivenPreviousBlockIs(string content)
        {
            previousBlock = content[0];
        }

		[Given(@"current block is: (.*)")]
		public void GivenCurrentBlockIs(string content)
        {
            currentBlock = content[0];
        }

        [When(@"I execute the DetermineNextBlockInPath function")]
        public void WhenIExecuteTheDetermineNextBlockInPathFunction()
        {
            try
            {
                var gameMapService = mock.Create<GameMapService>();

                var previousGameBlock = gameMapService.FindSingleCharacterInGameMap(gameMap, previousBlock!.Value);
                var currentGameBlock = gameMapService.FindSingleCharacterInGameMap(gameMap, currentBlock!.Value);

                result = gameMapService.DetermineNextBlockInPath(gameMap, previousGameBlock, currentGameBlock);
            }
            catch (Exception ex)
            {
                actualException = ex;
            }
        }

        [Then(@"exception should be generated: (.*)$")]
        public void ThenExceptionShouldBeGenerated(string message)
        {
            actualException.Should().NotBeNull("Exception should be generated.");

            if (actualException != null)
            {
                actualException.Message.Should().Be(message, $"Exception should be: {message}");
            }
        }

        [Then(@"result should be: (.*)")]
        public void ThenResultShouldBe(string expectedResult)
        {
            actualException.Should().BeNull("Exception should not be generated.");
            if (actualException != null)
            {
                outputHelper.WriteLine("Exception: {0}", actualException.ToString());
            }

            result.Should().NotBeNull("Result should not be null.");

            result?.Content.Should().BeEquivalentTo(expectedResult[0]);
        }
    }
}
