using System;
using System.Collections.Generic;

namespace C_Sharp_Playground.Indexers
{
    class DictionaryCollection<TK,TV> {
		private Dictionary<TK, TV> myDict = new Dictionary<TK, TV>();

		public Dictionary<TK, TV>.KeyCollection Keys => myDict.Keys;

		public Dictionary<TK, TV>.ValueCollection Values => myDict.Values;

		public TV this[TK k] {
			get => myDict[k]; //Expression body definitions
			set => myDict.Add(k, value);
		}
	}
	class IndexerProgram
	{
		public IndexerProgram()
		{
			var idexer = new DictionaryCollection<string, string>();
			idexer["k1"] = "abcd";
			idexer["k2"] = "Wxyz";
			foreach( var k in idexer.Keys )
			{
				Console.WriteLine("idexer[{0}] = {1}", k, idexer[k]);
			}
		}
	}
}
