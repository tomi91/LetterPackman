using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPackman.Models
{
	public class MapProcessingResult
	{
		public bool IsSuccessful { get; set; }
		public string? ErrorMessage { get; set; }
		public string? CollectedLetters { get; set; }
		public string? TraversalPath { get; set; }
	}
}
