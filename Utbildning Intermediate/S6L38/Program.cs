using System;
using System.Collections.Generic;

namespace S6L38
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();

            List<IAction> list = new List<IAction>();

            list.Add(new VideoEncoding());
            list.Add(new UploadVideo());
            list.Add(new UpdateDatabas());
            list.Add(new SendEmail());

            Workflow workflow = new Workflow(list);

            workflowEngine.Run(workflow);

            float price = 5f;
            price.ToString("");
        }
    }
}
