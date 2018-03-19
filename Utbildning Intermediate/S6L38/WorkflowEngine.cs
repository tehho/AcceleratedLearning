
using System.Collections.Generic;

namespace S6L38
{
    public class WorkflowEngine
    {
        public WorkflowEngine()
        {
        }
        public IList<IAction> Actions { get; }

        public void Run(Workflow workflowObject)
        {
            workflowObject.Run();
        }
    }
}
