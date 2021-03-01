using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace task
{
    public class MyTask : Task
    {
        public override bool Execute()
        {
            Log.LogError(subcategory: null,
                           errorCode: "MyWarning12534",
                           helpKeyword: null,
                           file: null,
                           lineNumber: 0,
                           columnNumber: 0,
                           endLineNumber: 0,
                           endColumnNumber: 0,
                           message: "Hello from MyTask");

            return true;
        }
    }
}
