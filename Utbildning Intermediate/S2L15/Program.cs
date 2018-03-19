using System;

namespace S2L15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-
            var stopWatch = new StopWatch();

            stopWatch.Start();
            Run(2000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetTime());

            stopWatch.Start();
            Run(1000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetTime());

            try
            {
                stopWatch.Start();
                Run(1000);
                stopWatch.Start();
                Console.WriteLine(stopWatch.GetTime());
            }
            catch(InvalidOperationException IOE)
            {
                Console.WriteLine(IOE.Message);
            }

            // 2- 

            var post = Post.Create("Test", "This is a test", "Tehho");

            for ( int i= 0; i < 10; i++)
            {
                post.VoteUp();
            }

            post.Present();

            for (int i = 0; i < 15; i++)
            {
                post.VoteDown();
            }

            post.Present();
        }
        static void Run(int milliseconds)
        {
            var start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds <= milliseconds)
            {

            }
        }
    }
}
