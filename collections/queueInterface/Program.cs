using System;
using System.Collections.Generic;
namespace queueInterfaces
{
    class Program
    {
        static void Main(String[] Args)
        {
            // Queue<int> queue = new Queue<int>();
            //  queue.Enqueue(1);
            // queue.Enqueue(2);
            // queue.Enqueue(3);
            // queue.Enqueue(4);
            // queue.Enqueue(5);
            // queue.Enqueue(6);
            // queue.Enqueue(7);
            // queue.Enqueue(8);
            // queue.Enqueue(9);
            // var result = Queues.Reversing(queue);
            // Console.WriteLine(string.Join(',',result ));



        //     int N = 5;

        //  var binaries = BinaryQueue.BinaryGenerator(N);

        // Console.WriteLine("{\"" + string.Join("\", \"", binaries) + "\"}");
    




            var queue = Hospital.TreatmentOrder();

        Console.WriteLine("Treatment Order:");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }



        }
    }
}