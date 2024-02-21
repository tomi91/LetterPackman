using Autofac.Extras.Moq;
using FluentAssertions;
using LetterPackman.Models;
using LetterPackman.Services;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace LetterPackman.Tests.AcceptanceTests.GameMapServiceTests
{
	[Binding]
	[Scope(Feature = "ProcessGameMap")]
	public class ProcessGameMapStepDefinitions
	{
		private GameMap gameMap;
		private MapProcessingResult result;

		private readonly AutoMock mock;
		private readonly ISpecFlowOutputHelper outputHelper;

		public ProcessGameMapStepDefinitions(ISpecFlowOutputHelper outputHelper)
		{
			this.mock = AutoMock.GetStrict();
			this.outputHelper = outputHelper;
		}

		[Given(@"I have a map")]
		public void GivenIHaveAMap(Table table)
		{
			string[][] stringMap = table.Rows.Select(r => r.Values.ToArray()).ToArray();
			gameMap = new GameMap(stringMap);
		}

		[When(@"I execute the ProcessGameMap function")]
		public void WhenIExecuteTheProcessGameMapFunction()
		{
			var gameMapService = mock.Create<GameMapService>();

			result = gameMapService.ProcessGameMap(gameMap);
		}

		[Then(@"exception should be generated: (.*)$")]
		public void ThenExceptionShouldBeGenerated(string message)
		{
			result.IsSuccessful.Should().BeFalse("Exception should be generated.");

			if (!string.IsNullOrEmpty(result.ErrorMessage))
			{
				result.ErrorMessage.Should().Be(message, $"Exception should be: {message}");
			}
		}

		[Then(@"result should be Letters: (.*)")]
		public void ThenResultLettersShouldBe(string expectedResult)
		{
			CheckSuccessResult();
			result.CollectedLetters.Should().BeEquivalentTo(expectedResult);
		}

		[Then(@"result should be Path as characters: (.*)")]
		public void ThenResultPathShouldBe(string expectedResult)
		{
			CheckSuccessResult();
			result.TraversalPath.Should().BeEquivalentTo(expectedResult);
		}

		private void CheckSuccessResult()
		{
			result.IsSuccessful.Should().BeTrue("Exception should not be generated.");
			if (!string.IsNullOrEmpty(result.ErrorMessage))
			{
				outputHelper.WriteLine("Exception: {0}", result.ErrorMessage);
			}
		}
	}
}
