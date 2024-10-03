// -------------------------------------------------------------------
// File Path: Program.cs
// Description: Main application entry point. Handles mod creation logic and Python script running.
// -------------------------------------------------------------------

using System;                     // Make sure 'using' statements are at the top
using SimModX.Core;               // Import your ModCreator
using SimModX.PythonIntegration;  // Import your PythonRunner

class Program
{
    static void Main(string[] args)
    {
        // Test the mod creation functionality
        ModCreator modCreator = new ModCreator();

        Console.WriteLine("Enter the mod name:");
        string modName = Console.ReadLine();

        Console.WriteLine("Enter the mod description:");
        string description = Console.ReadLine();

        modCreator.CreateTraitMod(modName, description);
        Console.WriteLine("Mod creation complete.");

        // Test Python integration
        PythonRunner runner = new PythonRunner();
        string script = "result = 5 + 3"; // Sample Python script
        runner.ExecutePythonScript(script);
        var result = runner.GetVariable("result");
        Console.WriteLine("Result from Python: " + result);
    }
}
