using System;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Playground.TAP
{
    class BasicTask
    {
        public async Task DoTask()
        {
            var cts = new CancellationTokenSource();

            // Create a task
            Task<int> task = Task.Run(() =>
            {
                // some work
                Thread.Sleep(2000);
                return 42;
            }, cts.Token);

            // Cancel the task if needed
            if ((new Random()).NextDouble() >= 0.5) cts.Cancel();

            // Await the task and check properties
            try
            {
                int result = await task;
                Console.WriteLine($"Task completed successfully with result: {result}");
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Task failed with exceptions:");
                foreach (var innerEx in ex.InnerExceptions)
                {
                    Console.WriteLine(innerEx.Message);
                }
            }
            finally
            {
                // This Block will always execute even if no code from try and catch is executed
                Console.WriteLine($"Task Status: {task.Status}");
                Console.WriteLine($"Is Faulted: {task.IsFaulted}");
                Console.WriteLine($"Is Canceled: {task.IsCanceled}");
            }
        }
    }
}
