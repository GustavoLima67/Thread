using System;
using System.Threading;

namespace application
{
    class Program
    {
        static void Main(string [] args) 
        {

            /* Thread > Serve para executar duas linhas de codigos ao mensmo tempo 
            * e eles varia muito ao mesmo tempo ,
            * tambem normalmente esse numeros são aleatorios.
            */
            Thread t1 = new Thread(ThreadingRepetiçao);
            t1.Start();
            
            for(int i = 0;i < 100;i++)
            {
                Console.WriteLine("Main: "+i);
            }
            
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