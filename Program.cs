// -------------------------------------------------------------------
// File Path: Program.cs
// Description: Main entry point. Tests Python integration.
// -------------------------------------------------------------------

using System;  // Ensure that 'using' statements are at the top
using SimModX.PythonIntegration;  // Import PythonRunner

namespace SimModX
{
    class Program
    {
        static void Main(string[] args)
        {
            PythonRunner pythonRunner = new PythonRunner();

            // Sample Python script
            string script = @"
result = 5 + 3
";

            // Execute Python script
            pythonRunner.ExecutePythonScript(script);

            // Fetch the result from the Python script
            var result = pythonRunner.GetVariable("result");
            Console.WriteLine($"Result from Python: {result}");
        }
    }
}
