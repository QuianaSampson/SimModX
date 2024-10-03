// -------------------------------------------------------------------
// File Path: PythonIntegration/PythonRunner.cs
// Description: Handles running Python scripts within the application.
// -------------------------------------------------------------------

using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace SimModX.PythonIntegration
{
    public class PythonRunner
    {
        private ScriptEngine engine;
        private ScriptScope scope;

        public PythonRunner()
        {
            engine = Python.CreateEngine(); // Create Python engine
            scope = engine.CreateScope();   // Create a scope for variables
        }

        // Method to run a Python script
        public void ExecutePythonScript(string script)
        {
            try
            {
                engine.Execute(script, scope); // Run the Python script
            }
            catch (Exception ex)
            {
                Console.WriteLine("Python Script Error: " + ex.Message);
            }
        }

        // Method to get a Python variable
        public dynamic GetVariable(string variableName)
        {
            return scope.GetVariable(variableName);
        }
    }
}
