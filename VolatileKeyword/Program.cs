using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VolatileKeyword
{
    public class Worker
    {
        private volatile bool shouldStop;
        public void DoWork()
        {
            while (shouldStop)
            {
                Console.WriteLine("Worker thread: working...");
            }
            Console.WriteLine("Worker thread: terminating gracefully.");
        }
        public void RequestStop()
        {
            shouldStop = true;
        }
    }
    public class WorkerThreadExample
    {
        static void Main()
        {
            Worker workerObject = new Worker();
            Thread workerThread = new Thread(workerObject.DoWork);
            workerThread.Start();
            Console.WriteLine("Main thread: starting worker thread...");
            while (!workerThread.IsAlive) ;
            Thread.Sleep(1);
            workerObject.RequestStop();
            workerThread.Join();
            Console.WriteLine("Main thread: worker thread has terminated.");
            Console.Read();
        }
    }
}
