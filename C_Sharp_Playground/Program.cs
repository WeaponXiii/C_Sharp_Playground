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
        /*
		static async Task Main(string[] args)
		{
			await (new BasicTask()).DoTask();
		}
		*/

        // The following will not work for two reasons
        //	i. The class is not public
        // ii. LinqVsGenericBuiltIn will be recognized as namespace
        //      even after a specific "using C_Sharp_Playground.LinqVsGenericBuiltIn;" statement
        // static void Main() => new LinqVsGenericBuiltIn();
        static void Main() => new LinqVsGenericBuiltIn.LinqVsGenericBuiltIn();
    }
}
