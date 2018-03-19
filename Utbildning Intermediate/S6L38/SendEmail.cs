using System;

namespace S6L38
{
    public class SendEmail : IAction
    {
        public void Execute()
        {
            Console.WriteLine("Sending confirmation to users email...");
        }
    }

}
