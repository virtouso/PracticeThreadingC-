// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine( Thread.CurrentThread.ManagedThreadId);
var res = CheckThreads();
Console.ReadLine();


async Task<int> CheckThreads()
{
    int x = 1;
    Console.WriteLine(AppDomain.GetCurrentThreadId());

    await Task.Run(() => Console.WriteLine("ddd" + Thread.CurrentThread.ManagedThreadId));
  await  Task.Delay(100);
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    return 1;
}