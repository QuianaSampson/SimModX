// -------------------------------------------------------------------
// File Path: Program.cs
// Description: Main application entry point. Handles calling PythonRunner.
// -------------------------------------------------------------------

using System;
using SimModX.PythonIntegration;

class Program
{
    static void Main(string[] args)
    {
        PythonRunner runner = new PythonRunner(); // Create the Python runner
        string script = "result = 5 + 3";         // Sample Python script
        runner.ExecutePythonScript(script);       // Run the script

        var result = runner.GetVariable("result"); // Get the result from Python
        Console.WriteLine("Result from Python: " + result); // Print the result
    }
}
