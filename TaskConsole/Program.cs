using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    //EXECUTA TAFEREAS E MULT THREADS
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            //Formas de iniciar um task
            //Task t = new Task(Tarefa);
            //t.Start();

            //Task t2 = Task.Run(Tarefa);

            //Task.Run(Tarefa);

            //Task.Factory.StartNew(Tarefa); //podemos passar metodos com retorno e utiliza-lo

            //tarefa anonima
            //Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa Anônima");
            //    }
            //});

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Tarefa Principal");
            //}
            #endregion

            #region Parte 2
            //Array de task
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Array de Tarefa 1");
            //    }),
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Array de Tarefa 2");
            //    }),
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Array de Tarefa 3");
            //    })
            //};



            //execultando as tarefas do Array primeiro
            //Task.WaitAll(tasks);

            //Console.WriteLine("Tarefa principal");

            //escolhendo tarefas a serem executadas
            //Task t1 = Task.Run(() => { Console.WriteLine("Comando 1"); });
            //Task t2 = Task.Run(() => { Console.WriteLine("Comando 2"); });
            //Task t3 = Task.Run(() => { Console.WriteLine("Comando 3"); });

            //Task.WaitAll(t1, t2, t3);
            #endregion

            // realizando tarefas com parametros e retorno e na ordem em que uma depende da outra
            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(5));
            //Console.WriteLine(tarefa1.Result);

            //executando tarefa com retorno da anterior
            Task<int> tarefa1 = Task.Factory.StartNew(() =>
            {
                return new Random().Next(10);
            });

            Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
            {
                return "O valor final " + num.Result;
            });

            Console.WriteLine(tarefa3.Result);

            Console.ReadKey();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Task");
            }
        }
    }
}
