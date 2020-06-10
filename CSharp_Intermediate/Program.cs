using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
           var workFlow = new WorkFlow();
           workFlow.Add(new VideoEncoding());
           workFlow.Add(new Upload());

           var workFlowEngine = new WorkFlowEngine();
           workFlowEngine.Run(workFlow);
        }


        
        
    }

   
}
