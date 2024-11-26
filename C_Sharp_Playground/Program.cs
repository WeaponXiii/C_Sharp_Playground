using C_Sharp_Playground.TAP;
using System;
using System.Threading.Tasks;

namespace C_Sharp_Playground
{
	class Program
	{
		/*static void Main(string[] args)
		{
            //new Indexers.IndexerProgram();
            //new GenericExtension.GenenricExtRunner();
            new LinqTryOuts.GroupOuterJoinWithSelectMany();

			Console.ReadKey();
		}*/

		static async Task Main(string[] args)
		{
			await (new BasicTask()).DoTask();
		}
	}
}
