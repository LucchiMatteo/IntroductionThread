using System;
using System.Threading; //1

namespace IntroductionToThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prima di avviare i thread");
            //3 creazione dell'oggetto thread
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1)); //4 i metodi sono statici quindi non devo istanziare nulla (i thread possono anche non essere statici)
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));

            t1.Start();
            t2.Start();

           

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main {0}", i);
            }

            
        }

        public class MyThread //2 classe che contiene i thread che verranno lanciati
        {

            public static void Thread1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread1 {0}", i); 
                   // Thread.Sleep(1); //5 metodo Sleep che sospende l'esecuzione di un thread per 1 ms

                }
            }

            public static void Thread2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread2 {0}", i);
                    
                }
            }
        }
    }
}
