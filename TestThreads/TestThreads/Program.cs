// See https://aka.ms/new-console-template for more information


using TestThreads;

Console.WriteLine("Hello, World!");
Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

Global g = new();

 Task.Run(Task1);
Task.Run(Task2);
Console.ReadLine();

void Task1()
{
    for (int i = 0; i < 1000; i++)
    {
      //  lock (g)
     //   {
            Global.Shared++;
            Console.WriteLine("t1-" + Global.Shared);
     //   }
    }
}

void Task2()
{
    for (int i = 0; i < 1000; i++)
    {
        Task.Run(() =>
        {
      //      lock (g)
        //    {
                Global.Shared++;
                Console.WriteLine("t2-" + Global.Shared);
         //   }
            
        });
    }
}