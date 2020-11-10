using System;
using System.Threading; //1

namespace IntroductionToThread
{
   
    class Program
    {
       // static bool tmp=false; 11 variabile per la gestisce della terminazione di un thread
        static void Main(string[] args)
        {
          //  Thread.CurrentThread.Start(); 7 anche il main è un thread richiamato con la proprietà Current Thread
            Console.WriteLine("Prima di avviare i thread");
            //3 creazione dell'oggetto thread
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1)); //4 i metodi sono statici quindi non devo istanziare nulla (i thread possono anche non essere statici), ThreadStart è un delegate
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
            /*  t1.Name = "Thread 1"; //8 con la proprietà Name si può assegnare un nome ad ogni thread
              t2.Name = "Thread 2";*/
           // t2.Priority = ThreadPriority.AboveNormal; //11 grazie alla proprietà priority posso comunicarlo al S.O., non esagerare con l'assegnazione di elevati valori di priorità

            t1.Start();
           // t1.Join(); //6 join per attendere la conclusione di un thread, se imposto tempo come parameto imposto un timeout in modo vada avanti l'esecuzione degli altri thread e del main
            t2.Start();

          //  t1.IsBackground = true; //12 se il thread viene impostato di background termina alla terminazione del thread principale (foreground)

            // Console.WriteLine(t1.IsAlive); 9 la proprietà isAlive è un booleano che indica se il thread è avviato o meno
            //Console.WriteLine(t2.ThreadState); 10 la proprietà ThreadState indica lo stato di un thread
            // 5 uccisione di un thread
            /*try 
            {
                t1.Abort();
            }
            catch 
            {
                Console.WriteLine("Eccezione per l'uccisione di un thread");
             
            }*/

           

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main {0}", i);
            }

            
        }

        public class MyThread //2 classe che contiene i thread che verranno lanciati
        {

            public static void Thread1() //i thread sono metodi con void e nessun parametro
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread1 {0}", i);
                   //  Thread.Sleep(100); //5 metodo statico Sleep che sospende l'esecuzione di un thread per 1 ms
                //    if (i == 5)
                //        tmp = true;

                }
            }

            public static void Thread2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Thread2 {0}", i);
                  //  if (tmp == true)
                  //      break;
                    
                }
            }
        }
    }
}
