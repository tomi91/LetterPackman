using LetterPackman.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPackman.Models
{
	public class GameMap
	{
		private GameMapBlock[][] Map { get; set; }

		public GameMap(GameMapBlock[][] map)
		{
			Map = map;
		}

		public GameMap(string[][] stringMap)
		{
			Map = stringMap.Select((row, i) =>
				row.Select((val, j) => new GameMapBlock
				{
					Row = i,
					Column = j,
					Content = val.Length > 0 ? val[0] : MapSymbols.EmptySpaceSymbol
				}).ToArray()
			).ToArray();
		}

		public int GetNumberOfMapRows() => Map.Length;

		public int GetNumberOfMapColumns() => Map[0].Length;

		public GameMapBlock? GetLeftBlockFrom(GameMapBlock block)
		{
			return GetBlockAtPosition(block.Row, block.Column - 1);
		}

		public GameMapBlock? GetRightBlockFrom(GameMapBlock block)
		{
			return GetBlockAtPosition(block.Row, block.Column + 1);
		}

		public GameMapBlock? GetTopBlockFrom(GameMapBlock block)
		{
			return GetBlockAtPosition(block.Row - 1, block.Column);
		}

		public GameMapBlock? GetBottomBlockFrom(GameMapBlock block)
		{
			return GetBlockAtPosition(block.Row + 1, block.Column);
		}

		public GameMapBlock? GetBlockAtPosition(int row, int column)
		{
			if (row < 0 || row >= GetNumberOfMapRows() || column < 0 || column >= GetNumberOfMapColumns())
			{
				return null;
			}

			return Map[row][column];
		}
	}
}
