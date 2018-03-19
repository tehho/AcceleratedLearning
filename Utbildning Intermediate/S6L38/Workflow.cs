
using System.Collections.Generic;

namespace S6L38
{
    public class Workflow
    {
        private readonly IList<IAction> actions;

        public Workflow(IList<IAction> actions)
        {
            this.actions = actions;
        }

        public void Run()
        {
            foreach (var action in actions)
            {
                action.Execute();
            }
        }
    }
}
