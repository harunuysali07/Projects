using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var threadbir = new Thread(() =>writemessagemutex("0"));
            threadbir.Start();
            var threadiki = new Thread(() => writemessagemutexiki("1"));
            threadiki.Start();
            var threaduc = new Thread(() => writemessagemutex("2"));
            threaduc.Start();
            Console.ReadKey();
        }
        public static Mutex m = new Mutex();
        static void writemessagemutex(string mesaj)
        {
            try
            {
                m.WaitOne()
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(2);
                    Console.Write(mesaj);
                }
            }
            finally
            {
                m.ReleaseMutex();
            }
        }
        static void writemessagemutexiki(string mesaj)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(2);
                    Console.Write(mesaj);
                }
            }
            finally
            {
            }
        }
    }
}
