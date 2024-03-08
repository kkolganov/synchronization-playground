using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SynchronizationPlayground.Tools
{
    internal class ReadWriteBlock
    {
        private static int _someNumber = 42;

        public static void Write()
        {
            var number = Random.Shared.Next(100);
            _someNumber = number;
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has updated the value to {number}");
        }

        public static void Read()
        {
            var number = _someNumber;
            Thread.Sleep(Random.Shared.Next(100));

            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} has read the value of {number}");
        }
    }
}
