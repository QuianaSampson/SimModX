// -------------------------------------------------------------------
// File Path: PythonIntegration/PythonRunner.cs
// Description: Handles the execution of Python scripts via IronPython.
// -------------------------------------------------------------------

using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace SimModX.PythonIntegration
{
    public class PythonRunner
    {
        private ScriptEngine _engine;
        private ScriptScope _scope;

        public PythonRunner()
        {
            _engine = Python.CreateEngine();
            _scope = _engine.CreateScope();
        }

        public void ExecutePythonScript(string script)
        {
            try
            {
                _engine.Execute(script, _scope);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Python script execution failed: {ex.Message}");
            }
        }

        public dynamic GetVariable(string variableName)
        {
            if (_scope.ContainsVariable(variableName))
            {
                return _scope.GetVariable(variableName);
            }
            else
            {
                Console.WriteLine($"Variable '{variableName}' not found in Python script.");
                return null;
            }
        }
    }
}
