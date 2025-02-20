/* using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreamCommunication{
    public static void Main(){
        using(AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out)){
            Thread readerThread = new Thread(() => {
                using(AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In,pipeServer.GetClientHandleAsString()))
                using(StreamReader reader = new StreamReader(pipeClient)){
                    Console.WriteLine("Received: "+reader.ReadLine());
                }
            });
            readerThread.Start();
            using(StreamWriter writer = new StreamWriter(pipeServer)){
                writer.WriteLine("Hello from writer thread!");
            }
            readerThread.Join();
        }
    }
}
 */