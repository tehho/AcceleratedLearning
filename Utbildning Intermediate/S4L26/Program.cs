using System;

namespace S4L26
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1-
            var stack = new Stack();

            try
            {

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                //stack.Clear();

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
