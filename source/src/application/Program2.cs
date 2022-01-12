using System;
using System.Threading;

namespace application
{
    class Program2
    {
        static void Main(string [] args)
        {

            Console.WriteLin("DataIni: "+ DateTime.Now);
            
            for(int i = 0; i < 4; i++)
            {
                Thread t1 = new Thread(ThreadingRepetiçao);
                t1.isBackground = true;
                t1.Start();
            }

            Console.WriteLine("Program finalized.");
            Console.ReadKey();
        }

        //IO - Tela(Monitor), Rede e Armazenamento.
        static void ThreadingRepetiçao()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Num: " +i);
            }
        }
    }
}