using LetterPackman.Models;
using LetterPackman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
	static void Main()
	{
		var map = GetGameMap();
		var gameMapService = new GameMapService();
		var result = gameMapService.ProcessGameMap(map);

		if (result.IsSuccessful)
		{
			Console.WriteLine($"Letters: {result.CollectedLetters}");
			Console.WriteLine($"Path as characters: {result.TraversalPath}");
		}
		else
		{
			Console.WriteLine($"Error: {result.ErrorMessage}");
		}
	}

	private static GameMap GetGameMap()
	{
		string[][] map =
		[
			["@", "-", "-", "-", "A", "-", "-", "-", "+", " "],
			[" ", " ", " ", " ", " ", " ", " ", " ", "|", " "],
			["x", "-", "B", "-", "+", " ", " ", " ", "C", " "],
			[" ", " ", " ", " ", "|", " ", " ", " ", "|", " "],
			[" ", " ", " ", " ", "+", "-", "-", "-", "+", " "]
		];

		//string[][] map =
		//[
		//	[" ", "+", "-", "L", "-", "+", " ", " "],
		//	[" ", "|", " ", " ", "+", "A", "-", "+"],
		//	["@", "B", "+", " ", "|", "|", " ", "H"],
		//	[" ", "+", "+", " ", "+", "+", " ", "x"]
		//];

		//string[][] map =
		//[
		//	[" ", " ", " ", " ", "+", "-", "O", "-", "N", "-", "+", " ", " "],
		//	[" ", " ", " ", " ", "|", " ", " ", " ", " ", " ", "|", " ", " "],
		//	[" ", " ", " ", " ", "|", " ", " ", " ", "+", "-", "I", "-", "+"],
		//	["@", "-", "G", "-", "O", "-", "+", " ", "|", " ", "|", " ", "|"],
		//	[" ", " ", " ", " ", "|", " ", "|", " ", "+", "-", "+", " ", "E"],
		//	[" ", " ", " ", " ", "+", "-", "+", " ", " ", " ", " ", " ", "S"],
		//	[" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|"],
		//	[" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "x"]
		//];

		var gameMap = new GameMap(map);

		return gameMap;
	}
}