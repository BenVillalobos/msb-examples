using Microsoft.Build.Framework;

namespace task
{
    public class MyITask : ITask
    {
        public IBuildEngine BuildEngine { get; set; }
        public ITaskHost HostObject { get; set; }

        public bool Execute()
        {
            BuildEngine.LogErrorEvent(new BuildErrorEventArgs("", "MSB1235", "", 0, 0, 0, 0, "Hello from MyITask", "", ""));
            return true;
        }
    }
}
