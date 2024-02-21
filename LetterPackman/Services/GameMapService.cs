using LetterPackman.Constants;
using LetterPackman.Models;

namespace LetterPackman.Services
{
	public class GameMapService
	{
		public MapProcessingResult ProcessGameMap(GameMap gameMap)
		{
			try
			{
				List<GameMapBlock> pathCollection = CalculateGameMapPath(gameMap); 
				return CreateMapProcessingResult(pathCollection);
			}
			catch (Exception ex)
			{
				return new MapProcessingResult
				{
					IsSuccessful = false,
					ErrorMessage = ex.Message
				};
			}
		}

		private static MapProcessingResult CreateMapProcessingResult(List<GameMapBlock> pathCollection)
		{
			return new MapProcessingResult
			{
				IsSuccessful = true,
				CollectedLetters = string.Concat(
					pathCollection
						.Distinct()
						.Select(x => x.Content)
						.Where(x => char.IsLetter(x) && x != MapSymbols.EndPositionSymbol)
					),
				TraversalPath = string.Concat(
					pathCollection.Select(x => x.Content)
					),
			};
		}

		private List<GameMapBlock> CalculateGameMapPath(GameMap gameMap)
		{
			GameMapBlock startingBlock = FindSingleCharacterInGameMap(gameMap, MapSymbols.StartPositionSymbol);
			GameMapBlock endingBlock = FindSingleCharacterInGameMap(gameMap, MapSymbols.EndPositionSymbol);

			GameMapBlock prevBlock = startingBlock;
			GameMapBlock? nextBlock = startingBlock;
			GameMapBlock? currentBlock;

			List<GameMapBlock> pathCollection = new();

			while (true)
			{
				currentBlock = nextBlock;

				CheckBlockForValidity(currentBlock);

				pathCollection.Add(currentBlock!);

				if (currentBlock == endingBlock)
					break;

				nextBlock = DetermineNextBlockInPath(gameMap, prevBlock!, currentBlock!);

				prevBlock = currentBlock!;
			}

			CheckPathCollectionForInvalidBlocks(pathCollection);

			return pathCollection;
		}

		public GameMapBlock? DetermineNextBlockInPath(GameMap gameMap, GameMapBlock prevBlock, GameMapBlock currentBlock)
		{
			if (prevBlock == currentBlock)
				return DetermineFirstBlockInPath(gameMap, currentBlock);

			int nextRow = currentBlock.Row - prevBlock.Row;
			int nextColumn = currentBlock.Column - prevBlock.Column;
			bool horizontalDirection = nextColumn != 0;

			if (currentBlock.Content == MapSymbols.DirectionChangeSymbol)
				return DetermineBlockAfterDirectionChange(gameMap, currentBlock, horizontalDirection);

			GameMapBlock? nextBlock = gameMap.GetBlockAtPosition(currentBlock.Row + nextRow, currentBlock.Column + nextColumn);
			if (CheckIfBlockIsValid(nextBlock))
				return nextBlock;

			if (char.IsLetter(currentBlock.Content))
				return DetermineBlockAfterDirectionChange(gameMap, currentBlock, horizontalDirection);

			return null;
		}

		private GameMapBlock DetermineBlockAfterDirectionChange(GameMap gameMap, GameMapBlock currentBlock, bool isHorizontalDirection)
		{
			IEnumerable<GameMapBlock?> candidates;
			if (isHorizontalDirection)
				candidates = [
					gameMap.GetTopBlockFrom(currentBlock),
					gameMap.GetBottomBlockFrom(currentBlock)
				];
			else
				candidates = [
					gameMap.GetLeftBlockFrom(currentBlock),
					gameMap.GetRightBlockFrom(currentBlock)
				];

			candidates = candidates.Where(x => x != null && x.Content != MapSymbols.EmptySpaceSymbol);
			int count = candidates.Count();

			if (count == 0)
				throw new Exception("Fake turn in map.");

			if (count > 1)
				throw new Exception("Fork in path found in map.");

			return candidates.Single()!;
		}

		private GameMapBlock DetermineFirstBlockInPath(GameMap gameMap, GameMapBlock currentBlock)
		{
			IEnumerable<GameMapBlock?> candidates = [
				gameMap.GetTopBlockFrom(currentBlock),
				gameMap.GetBottomBlockFrom(currentBlock),
				gameMap.GetLeftBlockFrom(currentBlock),
				gameMap.GetRightBlockFrom(currentBlock)
			];

			candidates = candidates.Where(x => x != null && x.Content != MapSymbols.EmptySpaceSymbol);
			int count = candidates.Count();

			if (count == 0)
				throw new Exception("No starting paths in map.");

			if (count > 1)
				throw new Exception("Multiple starting paths found in map.");

			return candidates.Single()!;
		}

		public GameMapBlock FindSingleCharacterInGameMap(GameMap gameMap, char searchChar)
		{
			IEnumerable<GameMapBlock> candidates = FindCharacterInGameMap(gameMap, searchChar)
				.Where(x => x != null)!;
			int count = candidates.Count();

			if (count == 0)
				throw new Exception($"Character '{searchChar}' not found in map.");

			if (count > 1)
				throw new Exception($"More that one '{searchChar}' found in map.");

			return candidates.Single();
		}

		private static IEnumerable<GameMapBlock?> FindCharacterInGameMap(GameMap gameMap, char searchChar)
		{
			for (int row = 0; row < gameMap.GetNumberOfMapRows(); row++)
			{
				for (int column = 0; column < gameMap.GetNumberOfMapColumns(); column++)
				{
					if (gameMap.GetBlockAtPosition(row, column)?.Content == searchChar)
					{
						yield return gameMap.GetBlockAtPosition(row, column);
					}
				}
			}
		}

		private static void CheckPathCollectionForInvalidBlocks(List<GameMapBlock> pathCollection)
		{
			char[] validChars = [
				MapSymbols.StartPositionSymbol,
				MapSymbols.EndPositionSymbol,
				MapSymbols.DirectionChangeSymbol,
				MapSymbols.HorizontalConnectionSymbol,
				MapSymbols.VerticalConnectionSymbol
			];

			if (pathCollection.Select(x => x.Content)
					.Any(x => !validChars.Contains(x) && !char.IsAsciiLetterUpper(x)))
				throw new Exception("Illegal letter in map.");
		}

		private static void CheckBlockForValidity(GameMapBlock? currentBlock)
		{
			if (!CheckIfBlockIsValid(currentBlock))
				throw new Exception("Broken path found in map.");
		}

		private static bool CheckIfBlockIsValid(GameMapBlock? block)
		{
			return block != null && block.Content != MapSymbols.EmptySpaceSymbol;
		}


	}
}
